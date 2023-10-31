
namespace Escalonador
{
    internal class Program
    {
        static void Main( string[] args )
        {
            bool continuarExecutando = true;

            while ( continuarExecutando )
            {
                Console.Clear();
                Console.WriteLine( " Tamanho do endereço virtual: " );
                Console.WriteLine( " 1 - Endereço 16 bits" );
                Console.WriteLine( " Qualquer outra coisa - Endereço 32 bits" );

                if ( Console.ReadLine() == "1" )
                {
                    Console.Clear();
                    Console.WriteLine( "Endereço virtual: " );

                    if ( ushort.TryParse( Console.ReadLine(), out ushort enderecoVirtual ) )
                    {
                        string binario = Convert.ToString( enderecoVirtual, 2 );
                        binario =  new string( '0', ( 16 - binario.Length ) ) + binario;

                        int paginacao = Convert.ToInt32( binario.Substring(0,4), 2 );
                        int deslocamento = Convert.ToInt32( binario.Substring( 4 ), 2 );

                        Console.WriteLine( $"Paginação: {paginacao}" );
                        Console.WriteLine( $"Deslocamento: {deslocamento}" );

                        Console.WriteLine( "Deseja Continuar? (s/n)" );

                        continuarExecutando = "s".Equals( Console.ReadLine() );

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine( "Endereço virtual 16 bits inválido! " );
                        Console.WriteLine( "Deseja Continuar? (s/n)" );

                        continuarExecutando = "s".Equals( Console.ReadLine() );
                        
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine( "Endereço virtual: " );

                    if ( uint.TryParse( Console.ReadLine(), out uint enderecoVirtual ) )
                    {
                        string binario = Convert.ToString( enderecoVirtual, 2 );
                        binario = new string( '0', ( 32 - binario.Length ) ) + binario;

                        int paginacao1 = Convert.ToInt32( binario.Substring( 0, 10 ), 2 );
                        int paginacao2 = Convert.ToInt32( binario.Substring( 10, 10 ), 2 );
                        int deslocamento = Convert.ToInt32( binario.Substring( 20 ), 2 );

                        Console.WriteLine( $"Paginação Nível 1: {paginacao1}" );
                        Console.WriteLine( $"Paginação Nível 2: {paginacao2}" );
                        Console.WriteLine( $"Deslocamento: {deslocamento}" );

                        Console.WriteLine( "Deseja Continuar? (s/n)" );

                        continuarExecutando = "s".Equals( Console.ReadLine() );
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine( "Endereço virtual 32 bits inválido! " );
                        Console.WriteLine( "Deseja Continuar? (s/n)" );

                        continuarExecutando = "s".Equals( Console.ReadLine() );

                    }
                }
                
            }

        }
    }
}