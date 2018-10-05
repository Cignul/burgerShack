-- CREATE TABLE smoothies (
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,
--   description VARCHAR(255) NOT NULL,
--   price DECIMAL(10,2) NOT NULL,
--   PRIMARY KEY(id)
-- );

-- INSERT INTO smoothies (name, description, price) 
-- VALUES ("The Plain Jane", "It is just ice cream", 7.99);

-- SELECT * FROM burgers;

-- ALTER TABLE burgers MODIFY COLUMN price DECIMAL(10,2);

-- UPDATE burgers SET 
--   price = 7.99, 
--   name = "The Plain Jane with Cheese", 
--   description = "Burger on a bun with cheese"
--   WHERE id = 1;

-- DELETE FROM burgers WHERE id = 1;

-- USER TABLE CREATIOn

CREATE TABLE users (
  id VARCHAR(255) NOT NULL,
  username VARCHAR(20) NOT NULL,
  email VARCHAR(255) NOT NULL,
  hash VARCHAR(255) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY email (email)
);

-- FAVORITES TABLE

CREATE TABLE userburgers(
  id int NOT NULL AUTO_INCREMENT,
  burgerId int NOT NULL,
  userId VARCHAR(255) NOT NULL,
  );