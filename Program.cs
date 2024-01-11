using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("11980613999", "iphone", "12391255", 1000);
Nokia nokia = new Nokia("11980613998", "XY", "12391255", 2000);


iphone.ReceberLigacao();
iphone.InstalarAplicativo("DioApp");


nokia.ReceberLigacao();
nokia.InstalarAplicativo("NokiaDioApp");