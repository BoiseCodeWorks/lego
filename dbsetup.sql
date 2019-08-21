CREATE TABLE IF NOT EXISTS kits (
  id int NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  instructions VARCHAR(255),
  price decimal,

  PRIMARY KEY(id)
);