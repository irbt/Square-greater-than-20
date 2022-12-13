// Write a query that returns list of numbers and their squares only if square is greater than 20

namespace program{
    class SquareTask{
        public static void Main (string [] arg){
            int [] numbers = {7,2,30};
            
            IEnumerable<int> tabNb =
            from number in numbers
            where number*number > 20 
            select number;

            foreach (int i in tabNb)
            {
                int square = i*i;
                Console.WriteLine(i + " - " + square); 
            }


        }
    }
}




//Expected input and output
//[7, 2, 30] → 7 - 49, 30 - 900