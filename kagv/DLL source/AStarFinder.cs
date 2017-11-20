using System.Threading.Tasks;
using C5;
using System;
using System.Collections.Generic;

namespace kagv {
    public class AStarParam : ParamBase {
        public delegate float HeuristicDelegate(int iDx, int iDy);


        public float Weight;

        public AStarParam(BaseGrid iGrid, GridPos iStartPos, GridPos iEndPos, float iweight, DiagonalMovement iDiagonalMovement = DiagonalMovement.IfAtLeastOneWalkable, HeuristicMode iMode = HeuristicMode.EUCLIDEAN)
            : base(iGrid, iStartPos, iEndPos, iDiagonalMovement, iMode) {
            Weight = iweight;
        }

        public AStarParam(BaseGrid iGrid, float iweight, DiagonalMovement iDiagonalMovement = DiagonalMovement.IfAtLeastOneWalkable, HeuristicMode iMode = HeuristicMode.EUCLIDEAN)
            : base(iGrid, iDiagonalMovement, iMode) {
            Weight = iweight;
        }

        internal override void _reset(GridPos iStartPos, GridPos iEndPos, BaseGrid iSearchGrid = null) {

        }
    }
    public static class AStarFinder {


        public static List<GridPos> FindPath(AStarParam iParam, decimal iWeight) {
            return FindPath(iParam, Convert.ToDouble(iWeight));
        }

        public static List<GridPos> FindPath(AStarParam iParam, double iWeight) {
            object lo = new object();
            //var openList = new IntervalHeap<Node>(new NodeComparer());
            var openList = new IntervalHeap<Node>();
            var startNode = iParam.StartNode;
            var endNode = iParam.EndNode;
            var heuristic = iParam.HeuristicFunc;
            var grid = iParam.SearchGrid;
            var diagonalMovement = iParam.DiagonalMovement;
            // var weight = iParam.Weight;
            var weight = iWeight;

            startNode.startToCurNodeLen = 0;
            startNode.heuristicStartToEndLen = 0;

            openList.Add(startNode);
            startNode.isOpened = true;

            while (openList.Count != 0) {
                var node = openList.DeleteMin();
                node.isClosed = true;

                if (node == endNode) 
                    return Node.Backtrace(endNode);
                
                var neighbors = grid.GetNeighbors(node, diagonalMovement);


                Parallel.ForEach(neighbors, neighbor =>
                {

                    if (neighbor.isClosed) return;
                    var x = neighbor.x;
                    var y = neighbor.y;
                    float ng = node.startToCurNodeLen + (float)((x - node.x == 0 || y - node.y == 0) ? 1 : Math.Sqrt(2));

                    if (!neighbor.isOpened || ng < neighbor.startToCurNodeLen) {
                        neighbor.startToCurNodeLen = ng;
                        if (neighbor.heuristicCurNodeToEndLen == null)
                            neighbor.heuristicCurNodeToEndLen = Convert.ToSingle(weight) * heuristic(Math.Abs(x - endNode.x), Math.Abs(y - endNode.y));
                        neighbor.heuristicStartToEndLen = neighbor.startToCurNodeLen + neighbor.heuristicCurNodeToEndLen.Value;
                        neighbor.parent = node;
                        if (!neighbor.isOpened) {
                            lock (lo) {
                                openList.Add(neighbor);
                            }
                            neighbor.isOpened = true;
                        } 
                    }
                });

            }
            return new List<GridPos>();

        }
    }
}
