
using System;

namespace Calculator00
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("tapez un nombre");
			string aString = Console.ReadLine();
			int a = Int32.Parse(aString);
			Console.WriteLine("tapez un nombre");
			string bString = Console.ReadLine();
			int b = Int32.Parse(bString);
			Hello();
			Addition(a,b);
			Multiplication(a,b);
			//string r = CompteARebours(13);
			Console.WriteLine(CompteARebours(13));
			RevertWord();
			
			Console.ReadKey(true);
		}
		public static void Hello(){
			Console.WriteLine("Hello world");
		}
		public static void Addition(int a, int b){
			Console.WriteLine(a+b);
		}
		public static void Multiplication(int a, int b){
			Console.WriteLine(a*b);
		}
		public static string CompteARebours(int debut){
			string resultat = "";
			for(int i = debut; i >=0; i--){
				resultat = resultat + i + "...";// resultat += i + "..."
			}
			return resultat;
		}
		public static void StringLength(string param){
			Console.WriteLine(param.Length);
		}
		public static void RevertExample(){
			string[] words = {"Quelle","est","cette","langue"};
			for(int i = words.Length-1; i >= 0;i--){
				Console.WriteLine(words[i]);
			}
		}
		public static void RevertWord(){
			string word = "revert";
			for(int i = word.Length-1; i >= 0;i--){
				Console.Write(word[i]);
			}
		}
		public static string ReplaceX(string toReplace){
			string result = "";
			
			for(int i = 0; i < toReplace.Length;i++){
				if(TesterVoyelle(toReplace[i])){
					result += "X";
				}else{
					result += toReplace[i];
				}
			}
			return result;
		}
		public static bool TesterVoyelle(char c){
			char[] voyelles = {'a','e','u','i','o'};
			for(int i = 0; i < voyelles.Length; i++){
				if(c == voyelles[i]){
					return true;
				}
			}
			return false;
		}
	}
}