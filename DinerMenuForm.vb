Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Diner Menu
'https://github.com/TaylorHerndon/DinerMenu

Public Class DinerMenuForm

    'Modifies the text of DisplaySpecialLabel to a description of a baked potato soup if soup button is pressed
    Private Sub SoupButtonClick(sender As Object, e As EventArgs) Handles SoupButton.MouseDown

        DisplaySpecialLabel.Text = "      ~ Guy Fieri's Loaded Baked Potato Soup ~     " & vbNewLine & vbNewLine &
                                   "Get ready to be happy with Guy Fieri's loaded baked" & vbNewLine &
                                   "  potato soup. This baby has a soul filling creamy " & vbNewLine &
                                   "potato soup body topped with your classic toppings " & vbNewLine &
                                   "  like chives, sharp cheddar, sour cream, and the  " & vbNewLine &
                                   "              allways loved crispy bacon.          "

    End Sub

    'Modifies the text of DisplaySpecialLabel to a description of a corn salad if the salad button is pressed
    Private Sub SaladButtonClick(sender As Object, e As EventArgs) Handles SaladButton.MouseDown

        DisplaySpecialLabel.Text = "~Guy Fieri's Chipotle Corn Salad and Grilled Bacon~" & vbNewLine & vbNewLine &
                                   "   Welcome to flavor town, 'If there's a vegtable  " & vbNewLine &
                                   "  that loves the grill it's corn. Carmelizing the  " & vbNewLine &
                                   "natural sugars, adding a bit of chipotle heat, then" & vbNewLine &
                                   "      kissing it with a little bit of bacon.'      "

    End Sub

    'Modifies the text of DisplaySpecialLabel to a description of Fish Tacos if the fish button is pressed
    Private Sub FishButtonClick(sender As Object, e As EventArgs) Handles FishButton.MouseDown

        DisplaySpecialLabel.Text = "      ~ Guy Fieri's Tequila Lime Fish Tacos ~      " & vbNewLine & vbNewLine &
                                   "Fresh caught mahi mahi marinated in tequila, cumin," & vbNewLine &
                                   "  and lime. Then grilled to perfection and served  " & vbNewLine &
                                   " with vinigar dressed cabbage and topped with lime " & vbNewLine &
                                   "                 crema and cilantro.               " & vbNewLine

    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click

        'Ends the program if Exit Button is clicked
        End

    End Sub

End Class