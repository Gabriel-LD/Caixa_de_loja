public class Program
  {
    public static void Main(string[] args)
    {
      int opcao, n,numero, soma=0,cheque=0,cartao=0,cedulas=0;
        for(n=0;n<3;n++)
        {
            Console.WriteLine("escolha opçao 1 = cheque \nescolha opçao 2 = cartao \nescolha opçao 3 = cedulas");
            opcao = int.Parse(Console.ReadLine());
            if(opcao==1) 
            {
               Console.WriteLine ("informe o valor a ser pago" );
                numero =int.Parse(Console.ReadLine());  
                Console.WriteLine (numero);
                cheque=soma+numero;
            }
            if(opcao==2) 
            {
                Console.WriteLine ("informe o valor a ser pago" );
                numero =int.Parse(Console.ReadLine());  
                Console.WriteLine (numero);
                cartao=soma+numero;
            }
            if(opcao==3) 
            {
                Console.WriteLine ("informe o valor a ser pago" );
                numero =int.Parse(Console.ReadLine());  
                Console.WriteLine (numero);
                cedulas=soma+numero;
            }
        }    
        soma=cheque+cartao+cedulas;
         Console.WriteLine("total pago cheque = " + cheque);
        Console.WriteLine("total pago cartao = " + cartao);
        Console.WriteLine("total pago cedula = " + cedulas);
        Console.WriteLine("total pago = " + soma);
    }
  }