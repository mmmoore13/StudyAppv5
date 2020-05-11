
### Given
 A user
### When

### Then

### And

### But

As a user of the app, I want to be able to rapidly input information that I wish to learn and study, then passively study it in a manner that I will infinitely less likely to forget it.

### Non-functional
> 1) A user input for flashcard information, form; non-functional
>    1) Upon initial startup, the user will be run through a brief explanation of app functions, and then brought to the input form. The initial form will have a four text fields. The first is for the term, which will be the anchor tag for the card. The second will be question field, which will be tied to the answer typed into the third field. The last is a subject or category field, where the subject which the term presently belongs to is placed (some terms can have multiple subjects: they can belong to math and/or science, etc.). After initial entry, the user will be able to recall term forms, and enter questions with subject tags.
> 
> 2) Interactive Multiple choice factors on the flash cards, non-functional
>        2) Once a card (or series thereof) have been entered, the program will automatically begin the study routine. Each flashcard will have multiple choice buttons, of which one will be correct, the other options being incorrect. The incorrect buttons will be a random assortment of answers that the user has entered for other terms. When the correct answer is clicked, the user will hear their voice (if they recorded themselves) reading the answer aloud; a correct answer will also score a +1 to the study score, which will increase the interval in which the card prompts the user for studying. The user will be given a second chance to answer after an incorrect answer, but a second incorrect answer will return the card to the back of the immediately studiable deck.
>    

### Functional  
> 3) Study Score, functional
>      3) The Study Score will be the system that gauges how much time is necessary between study sessions for each flashcard. A correct answer will give a score of +1, a correct answer in a short period of time (time will be flexible) will receive a score of +2; plus one will double the study interval, whereas +2 will increase the interval by 2.5. An incorrect answer followed by a correct answer will  reset the interval to what it was at the time of the review, and two incorrect answers will reset the study interval to the shorter interval prior.
>      
> 4) Timed responses, functional
>      4) Each flashcard will have a timer attached to it, counting down the allotted time to get a +2 score. As a piece of information becomes better remember, the time for a +2 decreases, as a faster response is necessary to prove knowledge.
>      
> 5) Accuracy rating, functional
>      5) Each flashcard will give the user two attempts to answer correctly. If answered correctly on the first attempt, the study interval will be doubled. If answered incorrectly but then correctly, the card will return to the back of the current study deck and will receive an interval increase of half. If incorrectly answered twice, the card will return to the back of the current study deck, but the study interval will decrease.
>      
> 6) Automated Study Reminder/Enforcer, functional
>      6) The app will come preloaded with regular intervals of study: the first study interval for a series of cards will be 5 min. A correct answer will double that interval (and the successive intervals after); an incorrect answer will halve that interval (and successive intervals after). The app will automatically prompt the user to study when the end of the study term has been reached. Sleeping time will be factored in, but due to rapid increase in study time (5min, 10 min, 20 min, 40 min, 60 min, 120 min, 240 min, 480 min, 960 min), sleep will most likely fall in between necessary study time.