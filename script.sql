alter session set "_ORACLE_SCRIPT"=true;
create user dbadmin identified by dbadmin
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
/
--Grant quyen cho dbadmin
grant create session, create user, drop user, create role, drop any role, create procedure, execute any procedure, alter any procedure, drop any procedure, select any table, create table, insert any table, update any table, drop any table to dbadmin with admin option;
grant dba to dbadmin;