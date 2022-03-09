cd C:\Integrations\services\LaveryInboundOutboundStream
SC CREATE LaveryInboundOutboundStream obj=LDBTREE\lmargelidon password=Dorianlola2$ start= auto binPath= "C:\Integrations\services\LaveryInboundOutboundStream\LaveryInboundOutboundStream.exe" DisplayName= "Lavery Inbound-OutBound Main"
sc description LaveryInboundOutboundStream "Main Lavery listeners containers for entreprise integration"
cd ..

