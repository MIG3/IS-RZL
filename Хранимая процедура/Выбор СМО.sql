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
/****** Object:  StoredProcedure [dbo].[Выбор_СМО]    Script Date: 19.01.2018 16:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Автор:		Губин Максим, группа 8о-408Б
-- =============================================
ALTER PROCEDURE [dbo].[Выбор_СМО]
	 @Дата_рождения date -- дата рождения
	,@Фамилия char(20)
	,@Имя char(20)
	,@Отчество char(20)
	,@Пол char(1)
	,@Номер_паспорта char(6)
	,@Серия_паспорта char(4)
	,@СМО char(50)
	,@Регион char(60)
	
AS
BEGIN
	--DECLARE @ЕНП char
	DECLARE @Тип char = 'ggwp';-- полис или временное свидетельство
	--,@Дата_начала date;


	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--DECLARE @flag int;
    -- Поиск человека в БД
	--IF ((SELECT  COUNT(*) FROM [Персоналные данные] AS PD
	---- like определяет, совпадает ли указанная символьная строка с заданным шаблоном
	--WHERE PD.Фамилия like '%' + RTRIM(@Фамилия) + '%'
	--AND PD.Имя like '%' + RTRIM(@Имя) + '%'
	--AND PD.Отчество like '%' + RTRIM(@Отчество) + '%'
	--AND PD.Дата_рождения > @Дата_рождения
	--AND PD.Дата_смерти <> '2018.01.17') = 0)
	--BEGIN
	--	;
	--	PRINT 'Такого человека в БД не существует';
	--	-- Здесь основная часть
	--	BEGIN TRANSACTION
	--	SET @flag = 0;
	--	SET @Тип_документа = 'Полис';
	--	--вызов формы с выбором СМО доступных в этом регионе 
	--	-- Вызов функции, выполняющей сохранение инфу о новом человеке(полисе) в бд 
	--	EXEC dbo.Добавление_пользователя @flag, @Фамилия, @Имя, @Отчество, @Пол, @Дата_рождения, @Тип_документа, @Номер_паспорта, @Серия_паспорта, @СМО, @Регион 
	--	COMMIT TRAN
	--END
	--ELSE
	--	IF (@Дата_рождения > GETDATE())
	--	BEGIN
	--		-- дата в будущем
	--		;
	--		THROW 90002, 'Ошибка при заполнении поля "Дата рождения"', 8;
	--	END
	--ELSE 
	--BEGIN 
	BEGIN TRANSACTION
	DECLARE @d int; 
	--= (SELECT ID_СМО FROM dbo.[Состтояние на учёте] 
	--						INNER JOIN dbo.[Застрахованное лицо] AS ZL ON ZL.ID_ЗЛ=dbo.[Состтояние на учёте].ID_ЗЛ
	--						INNER JOIN (SELECT ID_ЗЛ FROM dbo.[Персоналные данные] AS PD 
	--							WHERE PD.Имя = @Имя AND PD.Фамилия = @Фамилия AND PD.Отчество = @Отчество AND PD.Дата_рождения = @Дата_рождения) AS d
	--							ON ZL.ID_ЗЛ=d.ID_ЗЛ);
	--PRINT @d
	--DECLARE @Тип nvarchar(30);
	--SET  @Тип = (SELECT Тип_документа FROM [Персоналные данные] AS PD
	--	WHERE PD.Тип_документа like '%' + RTRIM(@Тип))
	--IF (@Тип = 'Полис')
		--BEGIN
		--PRINT 'У Вас уже есть полис'
		-- Вызов формы для запроса смены СМО
		--DECLARE @flag int = 1;
		--UPDATE dbo.[Состтояние на учёте] SET Дата_снятия = GETDATE()  WHERE dbo.[Состтояние на учёте].ID_СМО = @d
		--Добавление вызвать из приложения
		--EXEC dbo.Добавление_пользователя @flag, @Фамилия, @Имя, @Отчество, @Пол, @Дата_рождения, @Тип, @Номер_паспорта, @Серия_паспорта, @СМО, @Регион 
		--PRINT 'По техническим причинам функция смены полиса временно не работает.'
		-- Запись в БД информации о выбранном СМО, снятие с учёта в предыдущей СМО
		--END
	--ELSE PRINT 'У Вас имеется временное свидетельство. Полис изготавливается.'
	SET @d = (SELECT dbo.СМО.ID_СМО FROM dbo.СМО
				INNER JOIN dbo.[Состтояние на учёте] AS SY ON SY.ID_СМО=dbo.СМО.ID_СМО
				INNER JOIN dbo.[Застрахованное лицо] AS ZL ON ZL.ID_ЗЛ=SY.ID_ЗЛ
				INNER JOIN
					(SELECT ID_ЗЛ FROM dbo.[Персоналные данные] AS PD 
					WHERE PD.Имя = @Имя AND PD.Фамилия = @Фамилия AND PD.Отчество = @Отчество AND PD.Дата_рождения = @Дата_рождения) AS d
					ON ZL.ID_ЗЛ=d.ID_ЗЛ)
				UPDATE dbo.СМО SET Название = @СМО  WHERE dbo.СМО.ID_СМО = @d
	COMMIT TRANSACTION
END