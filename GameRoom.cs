using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameRoom
    {
        public void Game()
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock, or RPSLS for short!");
            Console.ReadLine();
        }
       /* display_welcome();
        display_rules();
        self.select_game_mode()
        self.play_round()
         # Here the Player One Select the gesture
        # self.player_one.gesture = self.player_one.gesture_list[self.display_options()] 
        # From here the machine takes the turn 
        #Console.Writeline(self.player_one.gesture) */



            
        
   /*
    def display_rules(self):
        Console.WriteLine('I will now explain the rules of RPSLS.')
        Console.Writeline('you will be able to choose a one or two player game')
        Console.Writeline('you will have the ability to choose one of the five gestures.')
        Console.Writeline('If you have the winning gesture, you will be awarded a score point.')
        Console.Writeline('There is a total of five rounds. whoever scores the most points will win the game.')
        Console.Writeline('The winning combinations are as follows')
        Console.Writeline('rock crushes scissors')
        Console.Writeline('scissors cut paper')
        Console.Writeline('paper covers rock')
        Console.Writeline('rock crushes lizard')
        Console.Writeline('lizard poisons spock')
        Console.Writeline('spock smashes scissors')
        Console.Writeline('scissors decapitates lizard')
        Console.Writeline('lizard eats paper')
        Console.Writeline('paper disproves spock')
        Console.Writeline('spock vaporizes rock')
        Console.ReadLine('\n'+'\n'+'Once you have read and understand the rules, please hit the enter key')

    def select_game_mode(self):
        self.selected_option = int (Console.ReadLine("Please select 1. for Player Vs Player or 2. For Player Vs Machine (Single Mode: ): ")) 
        if self.selected_option == 1:  #user has selected 2 Players
           self.player_one = Human()
           self.player_two = Human()

           Console.Writeline("You have selected Multiplayer Mode, Choose your gesture below...")


        else if self.selected_option == 2:    #user has selected Single mode

            self.player_one = Human()
            self.player_two = AI()
            Console.Writeline("You have selected Single player Mode")
        else:

            Console.Writeline("Plese select a Valid option, Press Enter to continue")
            Console.ReadLine('press the enter key to continue.')



    def display_options(self):
        
        for gesture in range(len(self.player_one.gesture_list)) :
            Console.Writeline(f'Please select {gesture} for {self.player_one.gesture_list[gesture]}')


        return_gesture = int (Console.ReadLine())    
        return return_gesture

    def compare_gesture() :
        pass

    def play_round(self) :
        this_round = 1
        while this_round <= 5:
            

            Console.Writeline(f'You are now starting round {this_round}')
            Console.ReadLine('Please press enter to choose your gesture')
            self.player_one.set_gesture()
            self.player_two.set_gesture()
            if self.player_one.gesture == 'Rock':
                if self.player_two.gesture == 'Rock':
                    Console.Writeline('This round is a tie!')
                else if self.player_two.gesture =='Paper':
                    Console.Writeline(f'paper covers rock,{self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else if self.player_two.gesture == 'Scissors':
                    Console.Writeline(f'rock smashes scissors, {self.player_one.name} wins this round')
                    self.player_one.score += 1
                else if self.player_two.gesture == 'Lizard':
                    Console.Writeline (f'rock smashes lizard, {self.player_one.name} wins this round')
                    self.player_one.score += 1
                else:
                    Console.Writeline(f'spock vaporizes rock, {self.player_two.name} wins this round')
                    self.player_two.score += 1



            else if self.player_one.gesture == 'Paper':
                if self.player_two.gesture == 'Paper':
                    Console.Writeline('this round is a tie!')
                else if self.player_two.gesture == 'Rock':
                    Console.Writeline (f'paper covers rock {self.player_one.name} wins this round!')
                    self.player_one.score += 1
                else if self.player_two.gesture == 'Scissors':
                    Console.Writeline(f'scissors cuts paper, {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else if self.player_two.gesture == 'Lizard':
                    Console.Writeline(f'lizard eats paper, {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else:
                    Console.Writeline(f'paper disproves spock, {self.player_one.name} wins this round!')
                    self.player_one.score += 1




            else if self.player_one.gesture == 'Scissors':
                if self.player_two.gesture == 'Scissors':
                    Console.Writeline('this round is a tie!')
                else if self.player_two.gesture == 'Rock':
                    Console.Writeline(f'rock smashes scissors {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else if self.player_two.gesture == 'Paper':
                    Console.Writeline(f'scissors cut paper {self.player_one.name} wins this round!')
                    self.player_one.score += 1
                else if self.player_two.gesture == 'Lizard':
                    Console.Writeline(f'scissors decapitates lizard {self.player_one.name} wins this round')
                    self.player_one.score += 1
                else:
                    Console.Writeline(f'spock smashes scissors, {self.player_two.name} wins this round!')
                    self.player_two.score += 1



            else if self.player_one.gesture == "Lizard":
                if self.player_two.gesture == 'Lizard':
                    Console.Writeline('this round is a tie!')
                else if self.player_two.gesture == 'Rock':
                    Console.Writeline(f'rock smashes lizard {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else if self.player_two.gesture == 'Paper':
                    Console.Writeline (f'lizard eats paper, {self.player_one.name} wins this round!')
                    self.player_one.score += 1
                else if self.player_two.gesture == 'Scissors':
                    Console.Writeline (f'scissors decapitates lizard, {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else:
                    Console.Writeline(f'lizard poisons spock, {self.player_one.name} wins this round!')
                    self.player_one.score += 1



            else if self.player_one.gesture == 'Spock':
                if self.player_two.gesture == 'Spock':
                    Console.Writeline('this round is a tie!')
                else if self.player_two.gesture == 'Rock':
                    Console.Writeline(f'spock vaporizes rock, {self.player_one.name} wins this round')
                    self.player_one.score += 1
                else if self.player_two.gesture == 'Paper':
                    Console.Writeline(f'paper disproves spock, {self.player_two.name} wins this round!')
                    self.player_two.score += 1
                else if self.player_two.gesture == 'Scissors':
                    Console.Writeline(f'spock smashes scissors, {self.player_one.name} wins thi round!')
                    self.player_one.score += 1
                else:
                    Console.Writeline(f'lizard poisons spock, {self.player_two.name} wins this round')
                    self.player_two.score += 1

            if self.player_one.score > 2:
                Console.Writeline(f"The Winner is {self.player_one.name}")
                break
             
             else if self.player_two.score > 2:
                Console.Writeline(f"The Winer is {self.player_two.name}")
                break
            else if this_round == 5 and self.player_one.score == self.player_two.score:
                Console.Writeline("This game is a tie, next score wins!")
                this_round = 4
                
            else if this_round == 5 and self.player_one.score > self.player_two.score:
                Console.Writeline(f'The winner is {self.player_one.name}')
                break
            else if this_round == 5 and self.player_one.score<self.player_two.score:
                Console.Writeline (f'The winner is {self.player_two.name}')
                break

            else:
                Console.WriteLine("Stop trying to break my game!");

            this_round += 1; */
    }
}
