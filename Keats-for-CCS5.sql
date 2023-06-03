-- Modified to work with DB2

CREATE TABLE
    edible_category(
        id int NOT NULL PRIMARY KEY,
        name varchar(100) NOT NULL
    );

CREATE TABLE
    ingredient(
        id int NOT NULL PRIMARY KEY,
        name varchar(100) NOT NULL UNIQUE,
        name_ph varchar(100) DEFAULT '',
        name_owner varchar(100) DEFAULT '',
        date_created date,
        thumbnail_image_link varchar(100),
        ingredient_desc varchar(500) DEFAULT '',
        category_id int,
        FOREIGN KEY(category_id) REFERENCES edible_category(id)
    );

CREATE TABLE
    ingredient_variant(
        id int NOT NULL PRIMARY KEY,
        name varchar(100) NOT NULL UNIQUE,
        name_ph varchar(100) DEFAULT '' -- temp edit
    );

CREATE TABLE
    ingredient_subvariant(
        id int NOT NULL PRIMARY KEY,
        name varchar(200) NOT NULL UNIQUE,
        name_ph varchar(100) DEFAULT ''
    );

CREATE TABLE
    nutrient(
        id int NOT NULL PRIMARY KEY,
        amount float4 NOT NULL,
        amount_unit varchar(4) NOT NULL,
        amount_unit_desc varchar(40) NOT NULL,
        serving_size float4 DEFAULT 0,
        calories float4 NOT NULL,
        protein float4 NOT NULL,
        carbs float4 NOT NULL,
        fats float4 NOT NULL
    );

CREATE TABLE
    ingredient_mapping(
        id int NOT NULL PRIMARY KEY,
        ingredient_id int NOT NULL,
        ingredient_variant_id int NOT NULL,
        ingredient_subvariant_id int NOT NULL,
        nutrient_id int NOT NULL UNIQUE,
        FOREIGN KEY(ingredient_id) REFERENCES ingredient(id),
        FOREIGN KEY(ingredient_variant_id) REFERENCES ingredient_variant(id),
        FOREIGN KEY(ingredient_subvariant_id) REFERENCES ingredient_subvariant(id),
        FOREIGN KEY(nutrient_id) REFERENCES nutrient(id) ON DELETE CASCADE
    );

CREATE TABLE
    ingredient_image(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        ingredient_mapping_id int NOT NULL,
        name_file varchar(100) NOT NULL,
        amount float4 NOT NULL,
        amount_unit varchar(4) NOT NULL,
        amount_unit_desc varchar(40) NOT NULL
    );

CREATE TABLE
    intake(
        id int GENERATED ALWAYS AS IDENTITY,
        account_id int NOT NULL,
        -- might be cause FOR error
        PRIMARY KEY(id, account_id),
        date_created timestamp,
        amount float4 NOT NULL,
        amount_unit varchar(4) NOT NULL,
        amount_unit_desc varchar(40) NOT NULL,
        serving_size float4 DEFAULT 0,
        ingredient_mapping_id int,
        FOREIGN KEY(ingredient_mapping_id) REFERENCES ingredient_mapping(id) --FOREIGN KEY(food_id) REFERENCES food(id)
    );

/*CREATE TABLE account_type(
 id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
 name varchar(50) UNIQUE NOT NULL,
 account_type_desc varchar(100)
 );*/

CREATE TABLE
    account(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        username varchar(50) UNIQUE NOT NULL,
        password varchar(50) NOT NULL --    account_type_id int NOT NULL,
        --    FOREIGN KEY(account_type_id) REFERENCES account_type(id)
    );

CREATE TABLE
    diet_plan(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        name varchar(50) UNIQUE NOT NULL,
        main_image_link varchar(50),
        background_color varchar(6),
        diet_plan_desc varchar(200),
        calorie_percentage int,
        protein_percentage int,
        fats_percentage int,
        carbs_percentage int
    );

CREATE TABLE
    activity_lvl(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        name varchar(50),
        main_image_link varchar(50),
        background_color varchar(6),
        activity_lvl_desc varchar(200),
        bmr_multiplier float
    );

CREATE TABLE
    account_vitals(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        account_id int NOT NULL UNIQUE,
        weight int2 NOT NULL,
        height int2 NOT NULL,
        birthday date NOT NULL,
        sex varchar(6) NOT NULL,
        activity_lvl_id int NOT NULL,
        diet_plan_id int NOT NULL,
        FOREIGN KEY(activity_lvl_id) REFERENCES activity_lvl(id),
        FOREIGN KEY(diet_plan_id) REFERENCES diet_plan(id)
    );

/*CREATE TABLE account_weight_changes(
 id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
 account_id int NOT NULL,
 weight int2 NOT NULL,
 date_created date
 );*/

/*CREATE TABLE measure_unit(
 id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
 name varchar(50),
 wt_solid_unit_small varchar(4) NOT NULL,
 wt_solid_desc_small varchar(40) NOT NULL,
 wt_solid_unit_medium varchar(4) NOT NULL,
 wt_solid_desc_medium varchar(40) NOT NULL,
 wt_solid_unit_large varchar(4) NOT NULL,
 wt_solid_desc_large varchar(40) NOT NULL,
 wt_liquid_unit_small varchar(4) NOT NULL,
 wt_liquid_desc_small varchar(40) NOT NULL,
 wt_liquid_unit_medium varchar(4) NOT NULL,
 wt_liquid_desc_medium varchar(40) NOT NULL,
 wt_liquid_unit_large varchar(4) NOT NULL,
 wt_liquid_desc_large varchar(40) NOT NULL
 );*/

CREATE TABLE
    consumer_profile(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        account_id int NOT NULL UNIQUE,
        account_image_link varchar(100),
        name_first varchar(50),
        name_last varchar(50),
        phone_number varchar(15),
        date_updated timestamp,
        date_created timestamp,
        account_vitals_id int NOT NULL,
        --    measure_unit_id int NOT NULL,
        --    FOREIGN KEY(measure_unit_id) REFERENCES measure_unit(id)
        FOREIGN KEY(account_vitals_id) REFERENCES account_vitals(id)
    );

CREATE TABLE
    daily_nutrients(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        account_id int NOT NULL,
        -- temp edit
        date_created date NOT NULL,
        calories float4 NOT NULL,
        protein float4 NOT NULL,
        carbs float4 NOT NULL,
        fats float4 NOT NULL,
        max_calories float4 NOT NULL,
        max_protein float4 NOT NULL,
        max_carbs float4 NOT NULL,
        max_fats float4 NOT NULL,
        activity_lvl_id int NOT NULL,
        diet_plan_id int NOT NULL,
        FOREIGN KEY(activity_lvl_id) REFERENCES activity_lvl(id),
        FOREIGN KEY(diet_plan_id) REFERENCES diet_plan(id)
    );

/*
 CREATE TABLE business_profile(
 id int PRIMARY KEY KEY GENERATED ALWAYS AS IDENTITY,
 account_id rowid NOT NULL UNIQUE,
 account_image_link varchar,
 name_business varchar,
 phone_number varchar,
 date_updated timestamp,
 date_created timestamp
 );
 -- VIEW
 CREATE VIEW ingredient_details AS
 SELECT 
 ingredient.id,
 ingredient.name,
 ingredient.name_ph,
 ingredient.name_owner,
 ingredient_variant.name as variant_name,
 ingredient_subvariant.name as subvariant_name,
 nutrient.amount,
 nutrient.amount_unit,
 nutrient.calories,
 nutrient.protein,
 nutrient.carbs,
 nutrient.fats
 FROM ingredient_mapping 
 JOIN ingredient on ingredient_mapping.ingredient_id = ingredient.id
 JOIN ingredient_variant on ingredient_mapping.ingredient_variant_id = ingredient_variant.id 
 JOIN ingredient_subvariant on ingredient_mapping.ingredient_subvariant_id = ingredient_subvariant.id 
 JOIN nutrient on ingredient_mapping.nutrient_id = nutrient.id 
 -- For Text Search
 create text search dictionary simple_tsd (
 template = pg_catalog.simple,
 stopwords = english
 );
 create text search configuration simple_tsc (copy = simple);
 alter text search configuration simple_tsc alter mapping for asciiword
 with simple_tsd;
 alter table food add column search_food tsvector generated always as (
 setweight(to_tsvector('english',coalesce(food.name, '')),'A') ||
 setweight(to_tsvector('english',coalesce(food.name_ph, '')),'B') ||
 setweight(to_tsvector('english',coalesce(food.name_owner, '')),'C')
 ) STORED;
 create index search_food_idx on food using GIN(search_food);
 --sample query (full text)
 select
 food.name,
 food.name_owner,
 food_nutrient.calories,
 food_nutrient.carbs,
 food_nutrient.fats,
 food_nutrient.protein,
 ts_rank_cd(
 search_food,
 to_tsquery('english', 'chicken')
 ) as ranking
 from food
 JOIN food_nutrient ON food.food_nutrient_id = food_nutrient.id
 where
 search_food @@to_tsquery('english', 'chicken')
 and name_owner = 'USDA'
 and food_category_id = 6 
 order by ranking desc;
 select * from food 
 where 
 search_food @@to_tsquery(
 'english',
 'Alcoholic & beverage'
 ) 
 and removed = false
 and name_owner = 'USDA'
 and food_category_id = 14
 order by name desc;
 select name, removed from food 
 where removed = false
 and name_owner = 'USDA'
 and food_category_id = 17
 order by name asc;
 SELECT 
 ingredient.name AS ingredient_name,
 ingredient_variant.name as part,
 ingredient_subvariant.name as cook_type,
 nutrient.calories,
 nutrient.carbs,
 nutrient.fats,
 nutrient.protein
 FROM ingredient_mapping
 JOIN ingredient on ingredient_mapping.ingredient_id = ingredient.id
 JOIN ingredient_variant on ingredient_mapping.ingredient_variant_id = ingredient_variant.id
 JOIN ingredient_subvariant on ingredient_mapping.ingredient_subvariant_id = ingredient_subvariant.id
 JOIN nutrient on ingredient_mapping.nutrient_id = nutrient.id;
 where ingredient.category_id = 4;
 
 CREATE TABLE food (
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 name varchar not null UNIQUE,
 name_ph varchar DEFAULT '',
 name_owner varchar DEFAULT '',
 date_created date,
 barcode varchar unique,
 thumbnail_image_link varchar,
 food_desc varchar default '',
 category_id int not null,
 food_type_id int not null,
 owner_id rowid not null,
 FOREIGN KEY(category_id) REFERENCES edible_category(id),
 FOREIGN KEY(food_type_id) REFERENCES food_type(id)
 );
 CREATE TABLE food_ingredient (
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 ingredient_mapping_id int NOT NULL,
 amount float4 NOT NULL,
 amount_unit varchar(4) NOT NULL,
 amount_unit_desc varchar(40) NOT NULL,
 serving_size float4 default 0,
 FOREIGN KEY(ingredient_mapping_id) REFERENCES ingredient_mapping(id)
 );
 --This table will be used in the case where the food does not have any ingredients
 CREATE TABLE food_nutrient (
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 nutrient_id int NOT NULL,
 food_id int NOT NULL UNIQUE,
 FOREIGN KEY(nutrient_id) REFERENCES nutrient(id),
 FOREIGN KEY(food_id) REFERENCES food(id)
 );
 CREATE TABLE food_image(
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 food_id int not null,
 name_file varchar not NULL,
 amount float4 not NULL,
 amount_unit varchar(4) not NULL,
 amount_unit_desc varchar(40) not NULL
 );
 CREATE TABLE food_intake(
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 food_id int NOT NULL,
 FOREIGN KEY(food_id) REFERENCES food(id)
 );
 CREATE TABLE food_intake_mapping(
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 amount float4 not NULL,
 amount_unit varchar(4) not NULL, 
 food_intake_id int NOT NULL,
 ingredient_mapping_id int NOT NULL,
 FOREIGN KEY(ingredient_mapping_id) REFERENCES ingredient_mapping(id)
 );
 --This table will be used in the case where the food_intake does not have any food_intake_mapping
 CREATE TABLE food_intake_nutrient (
 id int primary KEY GENERATED ALWAYS AS IDENTITY,
 amount float4 NOT NULL,
 amount_unit varchar(4) NOT NULL,
 amount_unit_desc varchar(40) NOT NULL,
 serving_size float4 default 0,
 food_intake_id int NOT NULL,
 nutrient_id int NOT NULL, 
 FOREIGN KEY(nutrient_id) REFERENCES nutrient(id)
 ); 
 CREATE TABLE food_type(
 id int primary key,
 name varchar not null
 ); 
 
 */