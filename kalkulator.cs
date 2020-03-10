class kalkulator {
	
	static void main (string[] args){
		int a=10; 
		int b=6;
		
		Console.Writeline("hasil tmabah {0} + {1} ={2}",a,b, T(a, b));
		Console.Writeline("hasil kurang {0} - {1} ={2}",a,b, K(a, b));
		
		Console.Writeline("\n tekan aja asu");
		Console.Readkey();
	}
	static int T(int a, int b)
	{
		return a+b;
	}
	static int K(int a, int b){
		return a - b;
	}
}