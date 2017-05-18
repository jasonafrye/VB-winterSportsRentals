'Program:	winterSportsRentals
'Developer:	Jason A. Frye
'Purpose:	This application will let the user (a store clerk) enter information about each customer’s rental. 
'           The user should be able to select multiple equipment items, a rental duration, and insurance.
'Date:	    9/18/2011

Option Strict On
Option Explicit On

Public Class frmBrowse

#Region "Click Events"

    Private Sub tsbGo_Click(sender As System.Object, e As System.EventArgs) Handles tsbGo.Click
        'Retrieves string data from url textbox and navigates to URL
        Dim strUrl As String = tstURL.Text.ToString
        webWeather.Navigate(strUrl)
    End Sub

#End Region

#Region "Form Events"

    Private Sub frmBrowse_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Navigates to default weather forecast url
        webWeather.Navigate("http://weather.weatherbug.com/CO/Aspen-weather.html")
    End Sub

    Private Sub webWeather_Navigated(sender As Object, e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles webWeather.Navigated
        'Retrieves URL from e and displays in URL textbox
        tstURL.Text = e.Url.ToString
    End Sub

#End Region

End Class