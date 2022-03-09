cd C:\Integrations\services\LaveryInboundOutboundStreamHA
SC CREATE LaveryInboundOutboundStreamHA start= auto binPath= "C:\Integrations\services\LaveryInboundOutboundStreamHA\LaveryInboundOutboundStream.exe" DisplayName= "Lavery Inbound-OutBound Ha"
sc description LaveryInboundOutboundStreamHA "HA Lavery listeners containers for entreprise integration"
cd ..

