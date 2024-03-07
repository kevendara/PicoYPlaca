--create database PicoYPlaca
--go

use PicoYPlaca
go
-- exec pa_PicoYPlaca 'AAC-0120'

Create proc pa_PicoYPlaca
(
	@numero_placa char(8)
)
as
	declare @ultimo_digito int;

	set @ultimo_digito = RIGHT(REPLACE(@numero_placa,'-',''), 1)

	if( @ultimo_digito = '1' or @ultimo_digito = '2')
	begin
		select 'Su placa '+@numero_placa+' no circula el d�a Lunes de 06:00 a 09:30 y de 16:00 a 21:00.'
				+ CHAR(13) + CHAR(10)+ 'Su placa '+@numero_placa+' puede circular S�bado, Domingo y Feriado.'
				as 'resultado'
	end

	if( @ultimo_digito = '3' or @ultimo_digito = '4')
	begin
		select 'Su placa '+@numero_placa+' no circula el d�a Martes de 06:00 a 09:30 y de 16:00 a 21:00.'
			+ CHAR(13) + CHAR(10)+ 'Su placa '+@numero_placa+' puede circular S�bado, Domingo y Feriado.'
				as 'resultado'
	end

	if( @ultimo_digito = '5' or @ultimo_digito = '6')
	begin
		select 'Su placa '+@numero_placa+' no circula el d�a Mi�rcoles de 06:00 a 09:30 y de 16:00 a 21:00.'
			+ CHAR(13) + CHAR(10)+ 'Su placa '+@numero_placa+' puede circular S�bado, Domingo y Feriado.'
				as 'resultado'
	end

	if( @ultimo_digito = '7' or @ultimo_digito = '8')
	begin
		select 'Su placa '+@numero_placa+' no circula el d�a Jueves de 06:00 a 09:30 y de 16:00 a 21:00.'
			+ CHAR(13) + CHAR(10)+ 'Su placa '+@numero_placa+' puede circular S�bado, Domingo y Feriado.'
				as 'resultado'
	end

	if( @ultimo_digito = '9' or @ultimo_digito = '0')
	begin
		select 'Su placa '+@numero_placa+' no circula el d�a Viernes de 06:00 a 09:30 y de 16:00 a 21:00.'
		+ CHAR(13) + CHAR(10)+ 'Su placa '+@numero_placa+' puede circular S�bado, Domingo y Feriado.'
				as 'resultado'
	end

	