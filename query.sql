-- СОЗДАНИЕ ТАБЛИЦ
CREATE TABLE Категории
(
	Код INT IDENTITY PRIMARY KEY,
	ИмяКатегории VARCHAR(55)
);

CREATE TABLE Продукты
(
	Код INT IDENTITY PRIMARY KEY,
	ИмяПродукта VARCHAR(55)
);

CREATE TABLE КатегорииПродуктов
(
	Код INT IDENTITY PRIMARY KEY,
	КодПродукта INT,
  	КодКатегории INT,
  	FOREIGN KEY (КодПродукта) REFERENCES Продукты(Код),
  	FOREIGN KEY (КодКатегории) REFERENCES Категории(Код)
);

-- ДОБАВЛЕНИЕ ДАННЫХ
INSERT INTO Категории(ИмяКатегории)
VALUES ('Высшая'),
	   ('Низшая'),
       ('Средняя');
       
INSERT INTO Продукты(ИмяПродукта)
VALUES ('Молоко'),
	   ('Сигареты'),
       ('Ножницы');
       
INSERT INTO КатегорииПродуктов(КодПродукта, КодКатегории)
VALUES (1, 1),
	   (1, 2),
       (2, 1);
       
-- ПОЛУЧЕНИЕ ПАР
SELECT ИмяПродукта, ИмяКатегории FROM Продукты
LEFT JOIN КатегорииПродуктов ON Продукты.Код = КатегорииПродуктов.КодПродукта
LEFT JOIN Категории ON Категории.Код = КатегорииПродуктов.КодКатегории
