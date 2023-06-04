-- Modified to work with DB2
-- To insert with DBeaver

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
        name varchar(100) NOT NULL UNIQUE,
        name_ph varchar(100) DEFAULT ''
    );

CREATE TABLE
    nutrient(
        id int NOT NULL PRIMARY KEY,
        amount float4 NOT NULL,
        calories float4 NOT NULL,
        protein float4 NOT NULL,
        carbs float4 NOT NULL,
        fats float4 NOT NULL,
        /* TO DROP COLUMNS BELOW AFTER INSERT */
        trans_fat float4 DEFAULT 0,
        saturated_fat float4 DEFAULT 0,
        sugars float4 DEFAULT 0,
        fiber float4 DEFAULT 0,
        sodium float4 DEFAULT 0,
        iron float4 DEFAULT 0,
        calcium float4 DEFAULT 0
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
    intake(
        id int GENERATED ALWAYS AS IDENTITY,
        account_id int NOT NULL,
        -- might be cause FOR error
        PRIMARY KEY(id, account_id),
        date_created timestamp,
        amount float4 NOT NULL,
        ingredient_mapping_id int,
        FOREIGN KEY(ingredient_mapping_id) REFERENCES ingredient_mapping(id) --FOREIGN KEY(food_id) REFERENCES food(id)
    );



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
        calorie_percentage int,
        protein_percentage int,
        fats_percentage int,
        carbs_percentage int
    );

CREATE TABLE
    activity_lvl(
        id int PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
        name varchar(50),
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
        /* TO DROP COLUMNS BELOW AFTER INSERT */
        trans_fat float4 NOT NULL DEFAULT 0,
        saturated_fat float4 NOT NULL DEFAULT 0,
        sugars float4 NOT NULL DEFAULT 0,
        fiber float4 NOT NULL DEFAULT 0,
        sodium float4 NOT NULL DEFAULT 0,
        iron float4 NOT NULL DEFAULT 0,
        calcium float4 NOT NULL DEFAULT 0,
        /* ^^^ TO DROP TABLE AFTER */
        FOREIGN KEY(activity_lvl_id) REFERENCES activity_lvl(id),
        FOREIGN KEY(diet_plan_id) REFERENCES diet_plan(id)
    );

