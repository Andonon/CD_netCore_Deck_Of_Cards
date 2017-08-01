# CD_netCore_Deck_Of_Cards
Troy Center troycenter1@gmail.com Aug 1 2017
Coding Dojo .netCore and C# fundamentals, Deck of Cards Assignment. 
Done as team event/presentation. 

<h1>Deck of Cards</h1>

<img src="https://s3.amazonaws.com/General_V88/boomyeah2015/codingdojo/curriculum/content/chapter/holding-a-hand-of-cards.jpg" alt="Coding Dojo Assignment Image">

      The goal of this assignment is to practice many of the OOP ideas we went over in the previous tabs. We will be constructing three different classes; Card, Deck, and Player, that should give us the base foundation for creating just about any card game we want! This is a very important assignment, as these concepts are the essentials to working with Classes, Objects, and their associated Methods All future lecture and assignments will continue to be built upon these concepts presented here as we continue through the course.

<h3>To Do</h3>

<h4>Create a class called "Card"</h4>

1. Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a String
2. Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
3. Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers

<h4>Next, create a class called "Deck"</h4>

4. Give the Deck class a property called "cards" which is a list of Card objects
5. When initializing the deck make sure that it has a list of 52 unique cards as its "cards" property
6. Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card
7. Give the Deck a reset method that resets the cards property to the contain the original 52 cards
8. Give the Deck a shuffle method that randomly reorders the deck's cards

<h4>Finally, create a class called "Player"</h4>

9. Give the Player class a name property
10. Give the Player a hand property that is a List of type Card
11. Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card
Note this method will require reference to a deck object
12. Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.



