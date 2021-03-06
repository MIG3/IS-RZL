/*    ==Параметры сценариев==

    Версия исходного сервера : SQL Server 2016 (13.0.4206)
    Выпуск исходного ядра СУБД : Выпуск Microsoft SQL Server Enterprise Edition
    Тип исходного ядра СУБД : Изолированный SQL Server

    Версия целевого сервера : SQL Server 2017
    Выпуск целевого ядра СУБД : Выпуск Microsoft SQL Server Standard Edition
    Тип целевого ядра СУБД : Изолированный SQL Server
*/

USE [ИС ЕРЗ]
GO
/****** Object:  StoredProcedure [dbo].[Добавление_пользователя]    Script Date: 19.01.2018 14:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Автор:		Губин Максим, группа 8о-408Б
-- =============================================
ALTER PROCEDURE [dbo].[Добавление_пользователя] 
	 @flag int
    ,@Фамилия char(20)
    ,@Имя char(20)
    ,@Отчество char(20)
    ,@Пол char
    ,@Дата_рождения date
    ,@Тип_документа char
    ,@Номер char(6)
    ,@Серия char(4)
	,@Название_СМО char(50)
	,@Название_региона char(60)
	

--DECLARE 
AS
BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION

	DECLARE @Номер_бланка int = 10, @Код int, @Дата_смерти date
    ,@Дата_начала date, @Дата_снятия date, @ЕНП char(16)
	,@ID_СМО int ,@ТФОМС char, @ID_ЗЛ int, @polis char(23);
	--SET @ЕНП = '5678937501192381';
	--SET @ЕНП = (SELECT dbo.Build_ENP(@Дата_рождения,@Пол, @Код)); -- функция не допиcана
	SET @ЕНП = (SELECT max(ЕНП) FROM [dbo].[Персоналные данные])+1;
	SET @Дата_начала = (SELECT CONVERT (date, GETDATE()));
	SET @Дата_снятия = NULL;
	SET @ТФОМС = 'xm';
	SET @Дата_смерти = GETDATE();
	
	INSERT INTO [dbo].[Застрахованное лицо] DEFAULT VALUES
	DECLARE @id INT = (SELECT SCOPE_IDENTITY())

	INSERT INTO [dbo].[Персоналные данные]
				([ID_ЗЛ],
				Фамилия
			   ,[Имя]
			   ,[Отчество]
			   ,[Пол]
			   ,[Дата_рождения]
			   ,[Дата_смерти]
			   ,[Тип_документа]
			   ,[Номер]
			   ,[ЕНП]
			   ,[Дата_начала]
			   ,[Серия])
		 VALUES
			   (@id,
			   @Фамилия
			   ,@Имя
			   ,@Отчество
			   ,@Пол
			   ,@Дата_рождения
			   ,@Дата_смерти
			   ,@Тип_документа
			   ,@Номер
			   ,@ЕНП
			   ,@Дата_начала
			   ,@Серия)
	
	IF (@flag = 0)
		BEGIN
			SET @polis = 'Временное свидетельство';
			INSERT INTO [dbo].ДПФС ([ID_ЗЛ], [Дата_выдачи], [Номер_бланка], [Срок_действия], [Тип])
				VALUES (@id, @Дата_начала, @Номер_бланка, DATEADD(month, 1, SYSDATETIME()), @polis)
			PRINT 'Вы получили временное свидетельство' -- ?
			SET @polis = 'Полис';
			UPDATE [dbo].ДПФС
			SET [dbo].ДПФС.Срок_действия = NULL, [dbo].ДПФС.Тип = @polis
			PRINT 'Вы получили полис'
		END
	ELSE
		BEGIN
			SET @polis = 'Полис';
			INSERT INTO [dbo].ДПФС ([Дата_выдачи], [Номер_бланка], [Срок_действия], [Тип])
				VALUES (@Дата_начала, @Номер_бланка, NULL, @polis)
			PRINT 'Вы прикреплены к новой СМО' -- ?
		END

	DECLARE @Код_региона int
		SET @Код_региона = (SELECT Код FROM [Коды субъектов] AS КС
		WHERE КС.Название like '%' + RTRIM(@Название_региона))
		-- в СМО записывается значение, когда чел выбирает СМО
		--вызов формы с выбором СМО доступных в этом регионе
		INSERT INTO [dbo].СМО ([Код_субъекта], [Название], [Субъект федерации])
			VALUES (@Код_региона, @Название_СМО, @Название_региона)

		DECLARE @id_cmo int;
		SET @id_cmo = (SELECT max(ID_СМО) FROM [dbo].[СМО])

		INSERT INTO [dbo].[Состтояние на учёте]
					([ID_ЗЛ],[ID_СМО], [Дата_постановки], [Дата_снятия])
			VALUES (@id, @id_cmo, @Дата_начала, @Дата_снятия)

COMMIT TRAN
END
