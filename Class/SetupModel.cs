using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatch.Class;
internal class SetupModel
{
    public List<TabLayoutModel> setupTabLayoutModel()
    {
        List<TabLayoutModel> tabLayoutModels = new List<TabLayoutModel>();

        String[] questionTitle =
        {
            "Question 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
            "Question 8",
            "Question 9",
            "Question 10"
        };

        String[] question =
        {
            "You want to give your significant other chocolates, but you only have milk, dark, and white chocolate. What should you do to find out which type they like?",
            "You have a bouquet of red and white roses, and you want to divide them equally between you and your significant other. How many of each color should each person receive?",
            "You want to write a love letter to your significant other, but you don't know where to start. What should you do first?",
            "You have a box of chocolates with different fillings, and you want to find out which one your significant other likes best. How many chocolates do you need to try to find out?",
            "You want to buy a gift for your significant other, but you're not sure what they need. What should you do to find out?",
            "You have a vase with a mixture of red and white roses, and you want to separate them into two vases with only one color in each. How many roses should you take from the original vase at a time?",
            "You have a collection of love letters, and you want to find the one written by your significant other. What should you do?",
            "How many chocolates should a man buy for his wife, if he wants to buy an odd number and the store only sells boxes of 9, 12, or 15?",
            "What bouquet of roses should a man buy for his girlfriend if she likes prime numbers and the florist has bouquets with 7, 11, 13, and 17 roses?",
            "What is the maximum number of $100 bills that each person can have, if they want to split a $100 bill evenly and each have an equal number of $100 bills?"
        };

        String[] questionAnswer =
        {
            "ASK",
            "SIX",
            "THINK",
            "TWO",
            "OBSERVE",
            "TWO",
            "READ",
            "NINE",
            "ELEVEN",
            "ONE"
        };

        String[] problemTitle =
        {
            "Problem 1",
            "Problem 2",
            "Problem 3",
            "Problem 4",
            "Problem 5",
            "Problem 6",
            "Problem 7",
            "Problem 8",
            "Problem 9",
            "Problem 10"
        };

        String[] problem =
        {
            "Write a program that takes a list of couples and returns a randomly assigned table for a Valentine's Day dinner party.",
            "Write a program that takes a list of gifts and returns a message saying \"I got you these gifts for Valentine's Day: [list of gifts]\" along with a personalized poem for each gift.",
            "Write a program that generates a personalized love letter based on input from the user, such as name, interests, and memories.",
            "Write a program that takes two people's names and returns a message saying \"Happy Valentine's Day [Name 1] and [Name 2]! You both have [percentage]% compatibility based on your favorite things.\"",
            "Write a program that takes a list of love songs and generates a playlist for a romantic evening.",
            "Write a program that takes a list of couples and returns a message saying \"Congratulations [Couple 1], [Couple 2], ... [Couple n]! You've won a romantic getaway for Valentine's Day.\"",
            "Write a program that takes a list of favorite movies and returns a message saying \"Let's watch our favorite romantic movies on Valentine's Day: [list of movies].\"",
            "Write a program that takes a list of favorite flowers and generates a bouquet for a special someone.",
            "Write a program that takes a list of couples and returns a message saying \"Happy Valentine's Day [Couple 1], [Couple 2], ... [Couple n]! Your love story is [random adjective] and [random adjective].\"",
            "Write a program that takes a list of couples and generates a personalized love story for each couple based on their names, interests, and memories."
        };

        for (int i = 0; i < 10; i++)
        {
            TabLayoutModel tabLayoutModel = new TabLayoutModel(questionTitle[i], question[i],
                questionAnswer[i], problemTitle[i], problem[i]);
            tabLayoutModels.Add(tabLayoutModel);
        }

        return tabLayoutModels;
    }
}
