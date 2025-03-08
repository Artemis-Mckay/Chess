# Xadrez WinForms

Instalation/Usage:
```bash
cd $HOME
git clone https://github.com/Artemis-TK/Xadrez.git
cd Xadrez
dotnet run
```

![Static Badge](https://img.shields.io/badge/⚠️Atenção⚠️-ffea00?style=for-the-badge&logoSize=40)<br>
Se você não clonar na sua `$HOME`, o programa não vai achar as imagens<br><br>
Se por algum motivo estiver dando erro ao tentar acessar as imagens, modifique a variável disk, da classe Pecas:

```csharp
public string disk { get; private set; } = "C"; // mude para "H"
```

Preview:<br><br>
![](./preview_image/image.png)