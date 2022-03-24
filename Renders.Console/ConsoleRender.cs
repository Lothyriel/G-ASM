using Domain.Render;
using System.Text;
using Object = Domain.GameEngine.Objects.Object;

namespace Renders.ConsoleRender
{
    public class ConsoleRender : IRender
    {
        private const int pxWidth = 9;
        private const int pxHeight = 21;

        public ConsoleRender(int width, int height, Camera camera, List<Object> objects)
        {
            ScreenWidth = width / pxWidth;
            ScreenHeight = height / pxHeight;
            Console.SetWindowSize(ScreenWidth, ScreenHeight);
            Console.BufferHeight = ScreenHeight;
            ScreenMatrix = new char[ScreenHeight, ScreenWidth];
            Objects = objects;
        }

        public char[,] ScreenMatrix { get; set; }
        public List<Object> Objects { get; }
        public int ScreenWidth { get; }
        public int ScreenHeight { get; }

        public void DrawFrame()
        {
            LoadMatrix();
            var frame = GetMatrixFrame();
            Console.Clear();
            Console.Write(frame);
        }

        private void LoadMatrix()
        {
            CleanMatrix();

            foreach (var obj in Objects)
            {
                DrawObjectPoints(obj);
            }
        }

        private void CleanMatrix()
        {
            for (int x = 0; x < ScreenMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < ScreenMatrix.GetLength(1); y++)
                {
                    ScreenMatrix[x, y] = ' ';
                }
            }
        }

        private void DrawObjectPoints(Object obj)
        {
            foreach (var (x, y) in obj.GetPoints())
            {                                               //filtrar o que vai aparecer na tela
                if (x > ScreenHeight || x < 0 || y > ScreenWidth || y < 0)
                    continue;

                ScreenMatrix[x, y] = '*';
            }
        }

        private string GetMatrixFrame()
        {
            var sb = new StringBuilder();

            for (int x = 0; x < ScreenMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < ScreenMatrix.GetLength(1); y++)
                {
                    sb.Append(ScreenMatrix[x, y]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}