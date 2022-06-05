
CREATE TABLE accessories (
    ac_id int   PRIMARY KEY IDENTITY,
    ac_name varchar(255)   NOT NULL
);

CREATE TABLE brand_name (
    name varchar(255)   PRIMARY KEY,
);

CREATE TABLE cpu_type (
    name varchar(255)   PRIMARY KEY,
);

CREATE TABLE processors (
    cpu_id int   PRIMARY KEY IDENTITY,
    cpu_brand varchar(255)   REFERENCES cpu_type(name) NOT NULL, 
    cpu_model varchar(255)   NOT NULL,
    cpu_socket text   NOT NULL,
    cpu_cores int   NOT NULL,
    cpu_threads int   NOT NULL,
    cpu_base_speed real   NOT NULL,
    cpu_max_speed real   NOT NULL,
    cpu_cache int   NOT NULL,
    cpu_tdp int   NOT NULL,
    cpu_graphics text   NOT NULL,
    cpu_equipment varchar(255)   NOT NULL,
    cpu_price real   NOT NULL,
    cpu_status varchar(255)   NOT NULL,
    cpu_access_id int  REFERENCES accessories(ac_id) DEFAULT 1 NOT NULL
);

CREATE TABLE motherboards (
    m_id int   PRIMARY KEY IDENTITY,
    m_brand varchar(255)   REFERENCES brand_name(name) NOT NULL,
    m_model varchar(255)   NOT NULL,
    m_cpu_type varchar(255)   REFERENCES cpu_type(name) NOT NULL,
    m_ram_memory varchar(255)   NOT NULL,
    m_form_factor text   NOT NULL,
    m_memory_slots int   NOT NULL,
    m_max_memory real   NOT NULL,
    m_socket text   NOT NULL,
    m_sata_slots int   NOT NULL,
    m_usb_count int   NOT NULL,
    m_price real   NOT NULL,
    m_status varchar(255)   NOT NULL,
    m_access_id int  REFERENCES accessories(ac_id) DEFAULT 2 NOT NULL
);

CREATE TABLE videocards (
    v_id int   PRIMARY KEY IDENTITY,
    v_brand varchar(255)   REFERENCES brand_name(name) NOT NULL,
    v_model varchar(255)   NOT NULL,
    v_memory_size int   NOT NULL,
    v_type_memory varchar(255)   NOT NULL,
    v_speed int   NOT NULL,
    v_connectors text   NOT NULL,
    v_price real   NOT NULL,
    v_status varchar(255)   NOT NULL,
    v_access_id int  REFERENCES accessories(ac_id) DEFAULT 3 NOT NULL
);

CREATE TABLE ssd_drives (
    ssd_id int   PRIMARY KEY IDENTITY,
    ssd_brand varchar(255)   REFERENCES brand_name(name) NOT NULL,
    ssd_model varchar(255)   NOT NULL,
    ssd_connectivity varchar(255)   NOT NULL,
    ssd_storage real   NOT NULL,
    ssd_nvme varchar(255)   NOT NULL,
    ssd_recording_speed real   NOT NULL,
    ssd_reading_speed real   NOT NULL,
    ssd_price real   NOT NULL,
    ssd_status varchar(255)   NOT NULL,
    ssd_access_id int  REFERENCES accessories(ac_id) DEFAULT 4 NOT NULL
);

CREATE TABLE ram (
    ram_id int   PRIMARY KEY IDENTITY,
    ram_brand varchar(255)   REFERENCES brand_name(name) NOT NULL,
    ram_model varchar(255)   NOT NULL,
    ram_type_memory varchar(255)   NOT NULL,
    ram_memory_size real   NOT NULL,
    ram_count int   NOT NULL,
    ram_speed int   NOT NULL,
    ram_rgb varchar(255)   NOT NULL,
    ram_price real   NOT NULL,
    ram_status varchar(255)   NOT NULL,
    ram_access_id int  REFERENCES accessories(ac_id) DEFAULT 5 NOT NULL
);

CREATE TABLE TestTable (
    Id INT IDENTITY NOT NULL PRIMARY KEY,
    TestFirstName VARCHAR(255) NOT NULL,
    TestLastName VARCHAR(255) NOT NULL,
    TestAge INT NOT NULL
)

INSERT INTO accessories
VALUES
('processors'),
('motherboards'),
('videocards'),
('RAM'),
('ssd_drivers');

INSERT INTO cpu_type
VALUES
('INTEL'),
('AMD');

INSERT INTO brand_name
VALUES
('ASRock'),
('Asus'),
('Gigabyte'),
('MSI'),
('Kingston'),
('Corsair'),
('Lexar'),
('Toshiba'),
('NZXT'),
('Chieftec'),
('Gamdias');
