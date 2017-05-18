'Program:	winterSportsRentals
'Developer:	Jason A. Frye
'Purpose:	This application will let the user (a store clerk) enter information about each customer’s rental. 
'           The user should be able to select multiple equipment items, a rental duration, and insurance.
'Date:	    9/18/2011

Option Strict On
Option Explicit On
Imports System.Convert



Public Class rental
    'declare properties
    Public Property Price As Double
    Public Property Duration As DurationType
    Public Property Equipment As EquipmentType
    'declare array for pricing numbers
    Private Shared mintPrices(,) As Integer = {{35, 45, 80, 150, 280}, {45, 55, 90, 160, 290}, {40, 50, 85, 155, 285}, {50, 60, 95, 165, 295}, {20, 30, 50, 90, 150}, {20, 30, 50, 90, 150}, {10, 20, 30, 50, 100}, {15, 25, 35, 70, 130}}

    Enum EquipmentType
        'enumerated type for equipment
        SkisBeginner
        SkisAdvanced
        SnowboardBeginner
        SnowboardAdvanced
        SkiBoots
        SnowboardBoots
        HelmetStandard
        HelmetDeluxe
    End Enum

    Enum DurationType
        'enumerated type for duration
        OneDay
        TwoDays
        ThreeDays
        OneWeek
        TwoWeeks
    End Enum

    Public Shared Function GetRentalPrice(ByVal duration As DurationType, ByVal equip As EquipmentType) As Double
        'this procedure will instantiate a new object and return the appropriate pricing information to the calling procedure
        Dim EQrent As New rental
        With EQrent
            .Equipment = equip
            .Duration = duration
            .Price = mintPrices(equip, duration)
        End With

        Dim RentalPrice As Double = EQrent.Price

        Return RentalPrice

    End Function

    Public Shared ReadOnly Property InsuranceCost(ByVal rentalAmount As Double) As Double
        'this readonly property simply calculates the insurance cost (10%) of the current transaction
        Get
            Dim sngIns As Single = 0.1
            InsuranceCost = rentalAmount * sngIns
            Return InsuranceCost
        End Get
    End Property

End Class
