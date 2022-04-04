alter session set "_ORACLE_SCRIPT"=true;
create user dbadmin identified by dbadmin
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
/
--Grant quyen cho dbadmin
grant dba to dbadmin;