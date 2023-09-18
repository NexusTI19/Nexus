Module myJobs(InputFile myJobs, Integer Ref earnedMoney)
Declare Boolean isWorking = True
While isWorking
   Declare String select
   While Not Eof(myJobs)
	Read myJobs select
	Display select
   End While

   Do
    Declare Integer choice
    Input choice
    If choice < 1 OR choice > 4 Then
	Display "Masukan angka antara 1-4"
    End If
   Until choice >= 1 AND choice <= 4

   Declare String kerjaLagi
    Select choice
	Case 1 :
	 Set earnedMoney = earnedMoney + 10000000  
	Case 2 :
	 Set earnedMoney = earnedMoney + 2500000
	Case 3 :
	 Set earnedMoney = earnedMoney + 100000
	Case 4 :
	 Set earnedMoney = earnedMoney + 1000000
     End Select  

     If earnedMoney < 800000 Then
	Display "Harus pilih lagi duit anda masih kekecilan"
	kerjalagi = true
     End If

     Do
    	Display "Mau kerja lagi (mau/tidak)"
	Input kerjaLagi
     Until kerjaLagi == "mau" OR kerjaLagi == "tidak"

     If kerjaLagi == "mau" Then
	isWorking = true
     Else 
        isWorking = false
     End If
End While	

End Module

Module thingsTodo(InputFile todo, Integer Ref moneyRemain)

Declare boolean pilihlagi = True
While pilihlagi
     Declare String select
     While Not Eof(todo)
	Read todo select
	Display select
     End While
   
     Select choice
	Case 1 :
	  If moneyRemain < 1500000 Then
 	    pilihlagi = True
	  Else
	    Set moneyRemain = moneyRemain - 1500000
	  End If
	   
	Case 2 :
	  If moneyRemain < 800000 Then
	    Display "Uang anda tidak cukup pilih yang lain"
 	    pilihlagi = True

	  Else
	    Set moneyRemain = moneyRemain - 800000
	  End If
	Case 3 :
	 If moneyRemain < 2000000 Then
 	    pilihlagi = True
	  Else
	    Set moneyRemain = moneyRemain - 2000000
	  End If
	Case 4 :
	 If moneyRemain < 11000000 Then
 	    pilihlagi = True
	  Else
	    Set moneyRemain = moneyRemain - 11000000
	  End If 
     End Select  

     Declare String pilihlagiGa
     If moneyRemain < 800000 Then
	Display "uang kamu sudah tidak bisa beli apa2"
	pilihlagi = false
     Else 
	Do
    	  Display "Mau pilih lagi (mau/tidak)"
	  Input pilihlagiGa
        Until pilihlagiGa == "mau" OR pilihlagiGa == "tidak"

        If pilihlagiGa == "mau" Then
	 plihlagi = true
        Else 
         pilihlagi = false
        End If
      End If

  End While
End Module


Module main()
   Declare InputFile myJobs
   Open myJobs "listofjobs.dat"
   Declare InputFile todo
   Open todo "todo.dat"
   Display "Earn Money First"

   Declare Integer earnedMoney = 0
   Call myJobs(myJobs, earnedMoney)

   Declare Integer moneyRemain = earnedMoney

   Call thingsToDo(todo, moneyRemain)

   Display "Your remaining money is : ", currencyFormat(moneyRemain)

   Display yang udah dibeli dengan write data

End Module


