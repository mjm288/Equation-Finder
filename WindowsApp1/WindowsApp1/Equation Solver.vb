Public Class Form1

    Private Sub Button1_Click(Sender As Object, e As EventArgs) Handles Button1.Click
        Dim Equation, strSum, strProduct As String
        Dim a, b, Sum, Product As Integer

        a = InputBox("Please enter alpha root:")
        b = InputBox("Please enter beta root: ")

        Sum = (a + b)
        Product = (a * b)

        MsgBox("Sum: " & Sum)
        MsgBox("Product: " & Product)

        If Sum < 0 Then
            Sum = (Sum * -1)
            strSum = (" + " & Sum & "x")
        Else
            strSum = (" - " & Sum & "x")
        End If

        If Product < 0 Then
            Product = (Product * -1)
            strProduct = (" - " & Product)
        Else
            strProduct = (" + " & Product)

        End If

        Equation = ("x^2" & strSum & strProduct & " = 0")
        MsgBox("Equation: " & Equation)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Equation, strSum, strCombi, strProduct As String
        Dim a, b, c, Sum, Combi, Product As Integer

        a = InputBox("Please enter alpha root: ")
        b = InputBox("Please enter beta root: ")
        c = InputBox("Please enter gamma root: ")

        Sum = (a + b + c)
        Combi = ((a * b) + (a * c) + (b * c))
        Product = (a * b * c)

        MsgBox("Sum: " & Sum)
        MsgBox("Combination of pairs: " & Combi)
        MsgBox("Product: " & Product)

        If Sum < 0 Then
            Sum = (Sum * -1)
            strSum = (" + " & Sum & "x^2")
        Else
            strSum = (" - " & Sum & "x^2")
        End If

        If Combi < 0 Then
            Combi = (Combi * -1)
            strCombi = (" - " & Combi & "x")
        Else
            strCombi = (" + " & Combi & "x")
        End If

        If Product < 0 Then
            Product = (Product * -1)
            strProduct = (" + " & Product)
        Else
            strProduct = (" - " & Product)
        End If

        Equation = ("x^3" & strSum & strCombi & strProduct & " = 0")
        MsgBox("Equation: " & Equation)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Equation, strSum, strCombiPair, strCombiTriple, strProduct As String
        Dim a, b, c, d, Sum, CombiPair, CombiTriple, Product As Integer

        a = InputBox("Please enter alpha root: ")
        b = InputBox("Please enter beta root: ")
        c = InputBox("Please enter gamma root: ")
        d = InputBox("Please enter delta root: ")

        Sum = (a + b + c + d)
        CombiPair = ((a * b) + (a * c) + (a * d) + (b * c) + (b * d) + (c * d))
        CombiTriple = ((a * b * c) + (a * b * d) + (d * c * b))
        Product = (a * b * c * d)

        MsgBox("Sum: " & Sum)
        MsgBox("Combination of Pairs: " & CombiPair)
        MsgBox("Combination of Triples: " & CombiTriple)
        MsgBox("Product: " & Product)

        If Sum < 0 Then
            Sum = (Sum * -1)
            strSum = (" + " & Sum & "x^3")
        Else
            strSum = (" - " & Sum & "x^3")
        End If

        If CombiPair < 0 Then
            CombiPair = (CombiPair * -1)
            strCombiPair = (" - " & CombiPair & "x^2")
        Else
            strCombiPair = (" + " & CombiPair & "x^2")
        End If

        If CombiTriple < 0 Then
            CombiTriple = (CombiTriple * -1)
            strCombiTriple = (" + " & CombiTriple & "x")
        Else
            strCombiTriple = (" - " & CombiTriple & "x")
        End If

        If Product < 0 Then
            Product = (Product * -1)
            strProduct = (" - " & Product)
        Else
            strProduct = (" + " & Product)
        End If

        Equation = ("x^4" & strSum & strCombiPair & strCombiTriple & strProduct & " = 0")
        MsgBox("Equation: " & Equation)
    End Sub



End Class
