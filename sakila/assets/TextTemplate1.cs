string conn_str = ConfigurationManager.ConnectionStrings["Sakila"].ConnectionString;
optionsBuilder.UseMySql(conn_str, x => x.ServerVersion("10.4.13-mariadb"));