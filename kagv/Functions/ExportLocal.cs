
using System.Windows.Forms;
using System.IO;
namespace kagv {
    public partial class main_form {
        private void ExportLocal() {
            int loads = 0;
            for (int i = 0; i < Globals._HeightBlocks; i++)
                for (int j = 0; j < Globals._WidthBlocks; j++)
                    if (m_rectangles[j][i].boxType == BoxType.Load)
                        loads++;

            if (loads == 0) {
                MessageBox.Show("No loads were found on the Grid.\nExported file was not created.\nYou will have to select a locally saved benchmark file.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            StreamWriter _writer = new StreamWriter("_tmpMap.txt");
            for (int i = 0; i < Globals._HeightBlocks; i++)
                for (int j = 0; j < Globals._WidthBlocks; j++)
                    if (m_rectangles[j][i].boxType == BoxType.Load) {
                        _writer.WriteLine(m_rectangles[j][i].x + "," + (this.Size.Height - m_rectangles[j][i].y));
                    }
            _writer.Close();
        }
    }
}
