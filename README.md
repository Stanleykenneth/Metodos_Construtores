# Metodos_Construtores

Este estudo referente ao aprendizado de como trabalhar com método e construtores, entendendo os fundamentos de instânciar um objeto e usar seus atributos.
Os construtores  permite que o programador defina valores padrões, limite a instanciação e grave códigos flexiveis e facies de ler.
Nesse curso estou trabalhando com a interpolação de string, facilitando a leitura e escrita do código, interpolando as strings facilita a forma de escrever e nãp orecisa fazer muitas concatenções.

Formatando valor monetário: 
 Formatando o valor monetário usando a classe CURRENCY, que formata o valor monetário de acordo com a geolocalização da configuração do sistema operacional da máquina do usuário. Neste caso em específico Formata em Real(Moeda Brasileira).
 Caso o sistema estaja hospedado em um servidor fora do Brasil, o programa apresentaria o valor monetário de acordo com a a geolocalização do sisterma do servidor.

 Para alterar a a geolocalização do sistema para formatar o valor monetário de uoutro país, podemos usar SYSTEM GLOBALIZATION passando os parametros CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); especificando em qual idioma o valor monetário seja impresso.

Formatando a estrutura DATETIME:
    É uma estrutura que existe no c# que serve para trabalhar com representação de data.
    DateTime.now = Reotrna a data atual da configuração do sistema que está sendo usado.
    Neste mesmo contexto podemos usar o ToString para formatar data no formato em que desejar.