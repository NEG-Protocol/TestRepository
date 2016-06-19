using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
	public partial class Form1 : Form
	{
		Tetris game = new Tetris();

		public Form1()
		{
			InitializeComponent();

			game.Initialize();
		}

		// 画面描画
		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Bitmap canvas = new Bitmap(drawArea.Width, drawArea.Height);
			Graphics g = Graphics.FromImage(canvas);

			DrawBlocks(g);

			g.Dispose();
			drawArea.Image = canvas;
		}

		private void DrawBlocks(Graphics g)
		{
			int blockX, blockY;

			for (int i = 0; i < game.Height; i++)
			{
				blockY = 480 - game.BlockHeight - game.BlockHeight * i;

				for (int j = 0; j < game.Width; j++)
				{
					blockX = game.BlockWidth * j;

					Brush brush = Brushes.Black;

					switch (game.Blocks[i, j])
					{
						case Tetris.BlockType.None:
							brush = Brushes.Black;
							break;

						case Tetris.BlockType.Wall:
							brush = Brushes.White;
							break;

						case Tetris.BlockType.Exist:
							brush = Brushes.Blue;
							break;

						default:
							brush = Brushes.Red;
							break;
					}

					g.FillRectangle(brush, new Rectangle(blockX, blockY, game.BlockWidth, game.BlockHeight));
					g.DrawRectangle(Pens.White, new Rectangle(blockX, blockY, game.BlockWidth, game.BlockHeight));
				}
			}
		}
	}

	public class Tetris
	{
		public enum BlockType
		{
			None,
			Wall,
			Exist,
		}

		public int BlockWidth { get; } = 20;
		public int BlockHeight { get; } = 20;

		public int Width { get; } = 12;
		public int Height { get; } = 23;

		public BlockType[,] Blocks { get; set; }

		// 初期化
		public void Initialize()
		{
			Blocks = new BlockType[Height, Width];

			for (int i = 0; i < Height; i++)
			{
				if (i == 0)
				{
					for (int j = 0; j < Width; j++)
					{
						Blocks[i, j] = BlockType.Wall;
					}
				}
				else if (i == Height - 1)
				{
					Blocks[i, 0] = Blocks[i, 1] = Blocks[i, 2] = Blocks[i, Width - 1] = Blocks[i, Width - 2] = Blocks[i, Width - 3] = BlockType.Wall;
				}
				else
				{
					Blocks[i, 0] = BlockType.Wall;
					Blocks[i, Width - 1] = BlockType.Wall;
				}

				Blocks[5, 5] = BlockType.Exist;
			}
		}
	}
}
