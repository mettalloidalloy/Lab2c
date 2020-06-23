using System;

class MainClass {
  public static void Main (string[] args) {
      Console.WriteLine("Enter a color name");
  string color = Console.ReadLine();

   switch(color)
   {
    case "yellow":     
    case "orange":
    case "red": 
    case "pink":  
    case "gold":     
      Console.WriteLine("The color " + color + " is warm");
      break;
    case "blue":  
    case "purple":     
    case "magenta":   
    case "green":
      Console.WriteLine("The color " + color + " is cool");
      break;
    case "black":    
    case "white":
    case "ivory":    
    case "brown":
    case "beige":   
      Console.WriteLine("The color " + color + " is neutral");
      break;
    default:
      Console.WriteLine("Unable to determine the color temperature for the color " + color);
      break;
   }
  }
}