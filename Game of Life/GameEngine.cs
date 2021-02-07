using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class GameEngine
    {
        public uint CurGen { get; private set; }
        private bool[,] field;
        private readonly int rows;
        private readonly int cols;
        public GameEngine(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];
            Random rand = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = rand.Next(density) == 0;
                }
            }
        }
        private int SchetSosed(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var iSC = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !iSC)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
         public void NextGeneration()
         {
            var newField = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var schetSosed = SchetSosed(x, y);
                    var hasLife = field[x, y];
                    if(!hasLife && schetSosed == 3)
                    {
                        newField[x, y] = true;
                    }
                    else if(hasLife && (schetSosed<2 || schetSosed>3))
                    {
                        newField[x, y] = false;
                    }
                    else
                    {
                        newField[x, y] = field[x, y];
                    }
                }
            }
            field = newField;
            CurGen++;
        }
        public bool[,] GetCurGen()
        {
            var result = new bool[cols, rows];
            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }
            return result;
        }
        private bool ValCellPos(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
        private void UpCell(int x, int y, bool state)
        {
            if (ValCellPos(x, y))
                field[x, y] = state;
        }
        public void AddCell(int x, int y)
        {
            UpCell(x, y, state: true);
        }
        public void RemoveCell(int x, int y)
        {
            UpCell(x, y, state: false);
        }
    }
}
