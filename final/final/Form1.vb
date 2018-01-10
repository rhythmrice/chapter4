Public Class Form1

    Private Sub Tbox1_TextChanged(sender As Object, e As EventArgs) Handles Tbox1.TextChanged
   

    End Sub





  
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Tbox1.Text = ("aries") Then
            lbl3.Text = (" If you keep moving at this rapid pace, you might end up tripping over your shoelaces," &
             ControlChars.NewLine & " or even falling on your face! It's far too tempting to simply rush ahead, especially" &
               ControlChars.NewLine & " when you've gotten used to this kind of speed, but your energy is warning you to hold" &
                  ControlChars.NewLine & " back during moments like this. If you can keep your eyes on what's right in front of" &
                ControlChars.NewLine & " you, your progress should be smooth.")
        End If

        If Tbox1.Text = ("taurus") Then
            lbl3.Text = (" No one can truly appreciates earthy pleasures quite like you, and right now, your" &
                       ControlChars.NewLine & " heightened senses are even sharper! Head outside and wander through the grass, take" &
                     ControlChars.NewLine & " an extra-long swim or stop to build the optimal sandcastle at a local beach." &
             ControlChars.NewLine & " Connections to nature ground you in a really good way, and make you more capable" &
                ControlChars.NewLine & " of dealing life's little stresses.")
        End If

        If Tbox1.Text = ("gemini") Then
            lbl3.Text = (" Is someone trying a little too hard to poke their nose into your business? If you" &
              ControlChars.NewLine & " want to keep your private business private, you need to do something out of character" &
                ControlChars.NewLine & " and keep silent. Not only does that totally confuse any gossips out there trying to" &
                  ControlChars.NewLine & " pry, it should also give you some much-needed space to clear your head and get a" &
                 ControlChars.NewLine & " handle on everything that's going on within and without you.")
        End If

        If Tbox1.Text = ("cancer") Then
            lbl3.Text = (" It may seem trivial to figure out where to seat everyone at a dinner party," &
                  ControlChars.NewLine & " but that's because you're the master of orchestrating such events -- especially" &
                   ControlChars.NewLine & " when they take place in your home. This business occupies you now, and rightfully" &
               ControlChars.NewLine & " so! You know that happiness is increased when great care is taken with all types" &
                   ControlChars.NewLine & " of matters -- big and small. Whatever you're planning is sure to be a hit.")
        End If

        If Tbox1.Text = ("leo") Then
            lbl3.Text = (" Think of your recent misfortune as an auspicious sign -- if you hadn't hit" &
                ControlChars.NewLine & " this bump and just carried on, as usual, it almost certainly would have exploded" &
                  ControlChars.NewLine & " in your face at exactly the wrong time! As it stands, you have plenty of time" &
                    ControlChars.NewLine & " to fix whatever isn't working and get yourself back in the game. Be grateful" &
                  ControlChars.NewLine & " for this downtime -- at least it gives you a chance to take care of business" &
               ControlChars.NewLine & " with somewhat less pressure.")
        End If

        If Tbox1.Text = ("virgo") Then
            lbl3.Text = (" Does your recent desire for excitement have you itching to push beyond your" &
                 ControlChars.NewLine & " usual boundaries? It may be newly acquired, but it certainly speaks to some" &
                  ControlChars.NewLine & " ancient needs you've put on hold for far too long. Right now you may feel" &
                  ControlChars.NewLine & " invincible and ready to try anything, especially if it's not a normal part" &
                   ControlChars.NewLine & " of your routine. It's time for you to explore the possibilities.\n")
        End If

        If Tbox1.Text = ("libra") Then
            lbl3.Text = (" You've got the touch when you're dealing with any personal situation -- especially" &
                     ControlChars.NewLine & " when you need to use your ear. Your excellent listening skills are just what" &
                  ControlChars.NewLine & " you need when someone close comes to you with grievances, even though you're" &
                  ControlChars.NewLine & " not on the list (thankfully). Your ability to hear people out without" &
                  ControlChars.NewLine & " interrupting or injecting your opinions is so healing and graceful that they" &
                ControlChars.NewLine & " are sure to adore you even more.")
        End If

        If Tbox1.Text = ("scorpio") Then
            lbl3.Text = (" Shake up your social life so that it serves a higher purpose. You need to" &
                  ControlChars.NewLine & " find ways to benefit others in all your interactions, from the very smallest" &
                 ControlChars.NewLine & " to the very largest. Your energy emphasizes altruism and service, but don't" &
                   ControlChars.NewLine & "worry about who to help -- your inner eye makes sure you're connecting with" &
                ControlChars.NewLine & " the right people, so your good deeds fall right into place.")
        End If

        If Tbox1.Text = ("sagittarius") Then
            lbl3.Text = (" If it feels like the professional pressure is mounting, you need to" &
                ControlChars.NewLine & " turn your attention to getting the job done. That proves that you mean" &
                ControlChars.NewLine & " what you say, and also that you have the chops to back it up. Keep your" &
                   ControlChars.NewLine & " eyes open and focused, and avoid all distractions (including all the" &
                  ControlChars.NewLine & " drama your colleagues are dreaming up right now). You know exactly what's necessary.")
        End If

        If Tbox1.Text = ("capicorn") Then
            lbl3.Text = (" You're always willing to work hard, even when the results don't show up" &
                 ControlChars.NewLine & " until far in the future. You, more than most people, understand the value" &
               ControlChars.NewLine & " of laying the groundwork and paying dues. Not only should your efforts" &
                ControlChars.NewLine & " ensure long-lasting success, but after all the time, energy and sweat " &
                  ControlChars.NewLine & " you've put into it, you should be better able to handle (and maintain)" &
                    ControlChars.NewLine & " that success when it does arrive.")
        End If

        If Tbox1.Text = ("aquarius") Then
            lbl3.Text = ("You know that you've3 got to back up your words with action, and your " &
                   ControlChars.NewLine & " energy couldn't be better for doing just that now. You shouldn't have " &
                  ControlChars.NewLine & " to make threats, but it's prudent to gently remind people that they're" &
                   ControlChars.NewLine & " dealing with someone who is willing to step up to a challenge when the" &
                      ControlChars.NewLine & " chance presents itself. This may come in handy if you run into someone" &
                     ControlChars.NewLine & "with a hidden agenda.")
        End If

        If Tbox1.Text = ("pisces") Then
            lbl3.Text = (" Your energy is definitely working in your favor, especially in" &
                  ControlChars.NewLine & " anything service-oriented or that puts others' needs first. Your" &
     ControlChars.NewLine & "high-powered sense of compassion is getting a real workout, and" &
          ControlChars.NewLine & " you should see great results when channeling those feelings into" &
      ControlChars.NewLine & "goals that help your local community. If you haven't already done" &
          ControlChars.NewLine & " so, pick a project and get to work!")
        End If


    End Sub
End Class
