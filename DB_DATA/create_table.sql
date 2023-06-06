CREATE TABLE IF NOT EXISTS m_sex (
    m_sex_id integer not null,
    m_sex_logic_name varchar(128) not null,
    m_sex_physics_name varchar(128) not null,
    created_at timestamp not null,
    create_user varchar(128),
    create_program varchar(128),
    updated_at timestamp not null,
    update_user varchar(128),
    update_program varchar(128),
    is_deleted boolean not null default false,
    PRIMARY KEY(m_sex_id)
);

CREATE TABLE IF NOT EXISTS m_director (
    m_director_id integer not null,
    m_director_logic_name varchar(128) not null,
    m_director_physics_name varchar(128) not null,
    created_at timestamp not null,
    create_user varchar(128),
    create_program varchar(128),
    updated_at timestamp not null,
    update_user varchar(128),
    update_program varchar(128),
    is_deleted boolean not null default false,
    PRIMARY KEY(m_director_id)
);

CREATE TABLE IF NOT EXISTS m_department (
    m_department_id integer not null,
    m_department_physics_name varchar(128) not null,
    created_at timestamp not null,
    create_user varchar(128),
    create_program varchar(128),
    updated_at timestamp not null,
    update_user varchar(128),
    update_program varchar(128),
    is_deleted boolean not null default false,
    PRIMARY KEY(m_department_id)
);
