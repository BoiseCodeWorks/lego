-- DROP TABLE IF EXISTS kitbricks;

-- CREATE TABLE IF NOT EXISTS kits (
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,
--   instructions VARCHAR(255),
--   price decimal(16,2),

--   PRIMARY KEY(id)
-- );

-- CREATE TABLE IF NOT EXISTS bricks (
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,

--   PRIMARY KEY(id)
-- );


-- CREATE TABLE IF NOT EXISTS kitbricks (
--   id int NOT NULL AUTO_INCREMENT,
--   kitId int NOT NULL,
--   brickId int NOT NULL,
--   quantity int DEFAULT 0, 


--   INDEX (kitId),

--   FOREIGN KEY(kitId)
--     REFERENCES kits(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY(brickId)
--     REFERENCES bricks(id)
--     ON DELETE CASCADE,


--   PRIMARY KEY(id)
-- );



-- INSERT INTO bricks (name)
-- VALUES ("SQUARE");

-- INSERT INTO bricks (name)
-- VALUES ("CUBE");

-- INSERT INTO bricks (name)
-- VALUES ("CIRCLE");

-- INSERT INTO bricks (name)
-- VALUES ("TRIANGLE");

-- INSERT INTO kitbricks (kitId, brickId, quantity)
-- VALUES (1, 2, 30);

-- INSERT INTO kitbricks (kitId, brickId, quantity)
-- VALUES (1, 4, 5);

SELECT *, b.name AS brickName FROM kitbricks kb
JOIN bricks b ON b.id = kb.brickId
JOIN kits k ON k.id = kb.kitId
WHERE kb.kitId = 1;