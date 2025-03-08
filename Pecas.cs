using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chess;

public abstract class Pecas : Form
{
    protected string disk { get; private set; } = "C";
    public string cor;
    public int linha;
    public int coluna;

    public PictureBox pictureBox = new PictureBox();

    public char[]? characterColumn { get; set; }
    protected int line;
    protected int column;

    List<char> _column_chars_list = new List<char>();

    public Pecas() {}
    public Pecas(string Cor, int Linha, int Coluna)
    {
        cor = Cor;
        linha = Linha;
        coluna = Coluna;
        line = linha + 1;
        column = coluna + 1;
    }
    public abstract bool MovimentoValido(int linhaDestino, int colunaDestino, Pecas pecaDestino);

    public abstract bool Xeque(Pecas rei, Pecas pecaAtacante, Pecas[,] tabuleiro);
}
