<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.num1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.num2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.num3 = New System.Windows.Forms.Label()
        Me.BtnJogar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.imagemResultado = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imagemResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(262, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jogo 7 da Sorte"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel1.Controls.Add(Me.num1)
        Me.Panel1.Location = New System.Drawing.Point(157, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(26, 19)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(46, 54)
        Me.num1.TabIndex = 3
        Me.num1.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.num2)
        Me.Panel2.Location = New System.Drawing.Point(323, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(27, 19)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(46, 54)
        Me.num2.TabIndex = 4
        Me.num2.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel3.Controls.Add(Me.num3)
        Me.Panel3.Location = New System.Drawing.Point(498, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 2
        '
        'num3
        '
        Me.num3.AutoSize = True
        Me.num3.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3.Location = New System.Drawing.Point(30, 19)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(46, 54)
        Me.num3.TabIndex = 5
        Me.num3.Text = "0"
        '
        'BtnJogar
        '
        Me.BtnJogar.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnJogar.Location = New System.Drawing.Point(53, 282)
        Me.BtnJogar.Name = "BtnJogar"
        Me.BtnJogar.Size = New System.Drawing.Size(103, 49)
        Me.BtnJogar.TabIndex = 3
        Me.BtnJogar.Text = "Jogar"
        Me.BtnJogar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Crimson
        Me.BtnSair.Location = New System.Drawing.Point(690, 393)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(86, 36)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'imagemResultado
        '
        Me.imagemResultado.Location = New System.Drawing.Point(203, 270)
        Me.imagemResultado.Name = "imagemResultado"
        Me.imagemResultado.Size = New System.Drawing.Size(371, 149)
        Me.imagemResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemResultado.TabIndex = 5
        Me.imagemResultado.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imagemResultado)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnJogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jogo 7 da Sorte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imagemResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents num1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnJogar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents imagemResultado As PictureBox
    Friend WithEvents num2 As Label
    Friend WithEvents num3 As Label

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub BtnJogar_Click(sender As Object, e As EventArgs) Handles BtnJogar.Click
        imagemResultado.Visible = False

        Randomize() REM - Aqui serve para gerar numeros aleatórios

        num1.Text = CStr(Int(Rnd() * 10)) REM - Aqui serve para declarar onde vai usar de de quantoa te quanto o numero vai!
        num2.Text = CStr(Int(Rnd() * 10)) REM - No caso aqui num1, num2 e num3, depois tranforma em string o numero gerado entre 0 a 9 e exibe!
        num3.Text = CStr(Int(Rnd() * 10))

        'Se todos os numeros forem igual a 7!
        If (num1.Text = "7" And num2.Text = "7" And num3.Text = "7") Then

            imagemResultado.Image = Image.FromFile("C:\Users\todeb\Desktop\Programação Visual\JogoDaSorte\img\ganhouMais.jpg")
            imagemResultado.Visible = True
            Beep()


        ElseIf (num1.Text = "7" Or num2.Text = "7" Or num3.Text = "7") Then
            imagemResultado.Image = Image.FromFile("C:\Users\todeb\Desktop\Programação Visual\JogoDaSorte\img\Win7.jpg")
            imagemResultado.Visible = True
            Beep()

        Else
            imagemResultado.Image = Image.FromFile("C:\Users\todeb\Desktop\Programação Visual\JogoDaSorte\img\Lose.jpg")
            imagemResultado.Visible = True
            Beep()
        End If

    End Sub
End Class
