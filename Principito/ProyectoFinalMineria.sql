
/*
MATRIZ DE CORRELACIÓN 
*/

-- Ruta de salida
DECLARE @ImagePath NVARCHAR(4000) = N'C:\Principito\matriz_correlacion_COMPLETA.png';

-- Consulta
DECLARE @sql_query AS NVARCHAR(MAX)
SET @sql_query = N'
    SELECT 
        budget_x, 
        revenue, 
        score,
        YEAR(date_x) AS release_year
    FROM 
        IMDBProyecto.dbo.imdb_movies 
    WHERE 
        budget_x > 0 
        AND revenue > 0 
        AND score > 0
        AND date_x IS NOT NULL
'

EXEC sp_execute_external_script
    @language = N'R',
    @script = N'
        library(corrplot)
        plot_output_path <- image_path
        cor_matrix <- cor(InputDataSet)
        png(plot_output_path, width = 800, height = 800, res = 100)
        mis_colores <- colorRampPalette(c("#B2182B", "white", "#2166AC"))(200)
        corrplot(cor_matrix,
                 method = "color",
                 type = "lower",
                 addCoef.col = "black",
                 tl.col = "black",
                 tl.srt = 45,
                 col = mis_colores
                 )
        dev.off()
        OutputDataSet <- data.frame(variable = row.names(cor_matrix), cor_matrix)
    ',
    @input_data_1 = @sql_query,
    @params = N'@image_path NVARCHAR(4000)', 
    @image_path = @ImagePath
    
-- Tabla de resultados
WITH RESULT SETS ((
    variable_medida NVARCHAR(100),
    budget_x FLOAT,
    revenue FLOAT,
    score FLOAT,
    release_year FLOAT
));
GO

/*
REGRESIÓN - INGRESOS vs. PRESUPUESTO 
*/

DECLARE @ImagePathReg1 NVARCHAR(4000) = N'C:\Principito\regresion_Ingresos_vs_Presupuesto.png';

DECLARE @sql_query_reg1 AS NVARCHAR(MAX)
SET @sql_query_reg1 = N'
    SELECT 
        budget_x, 
        revenue,
        score,
        YEAR(date_x) AS release_year
    FROM 
        IMDBProyecto.dbo.imdb_movies 
    WHERE 
        budget_x > 1000 
        AND revenue > 1000
        AND score > 0
        AND date_x IS NOT NULL
'

EXEC sp_execute_external_script
    @language = N'R',
    @script = N'
        # Definir variables
        Y_data <- log(InputDataSet$revenue)
        Y_label <- "Ingresos (Escala Log)"
        X_data <- log(InputDataSet$budget_x)
        X_label <- "Presupuesto (Escala Log)"
        
        plot_output_path <- image_path
        model <- lm(Y_data ~ X_data)
        
        png(plot_output_path, width = 800, height = 700, res = 100)
        plot(X_data, Y_data,
             main = "Regresión: Ingresos vs. Presupuesto",
             xlab = X_label,
             ylab = Y_label,
             pch = 16,
             col = rgb(0,0,0,0.3))
        abline(model, col = "blue", lwd = 2)
        dev.off()

        model_summary <- summary(model)$coefficients
        OutputDataSet <- data.frame(Termino = row.names(model_summary), model_summary)
    ',
    @input_data_1 = @sql_query_reg1,
    @params = N'@image_path NVARCHAR(4000)', 
    @image_path = @ImagePathReg1

WITH RESULT SETS ((
    Termino NVARCHAR(100),
    Estimate FLOAT,
    Std_Error FLOAT,
    t_value FLOAT,
    Pr_t FLOAT
));
GO

/*
REGRESIÓN - INGRESOS vs. CALIFICACIÓN 
*/

DECLARE @ImagePathReg2 NVARCHAR(4000) = N'C:\Principito\regresion_Ingresos_vs_Calificacion.png';

DECLARE @sql_query_reg2 AS NVARCHAR(MAX)
SET @sql_query_reg2 = N'
    SELECT 
        budget_x, 
        revenue,
        score,
        YEAR(date_x) AS release_year
    FROM 
        IMDBProyecto.dbo.imdb_movies 
    WHERE 
        budget_x > 1000 
        AND revenue > 1000
        AND score > 0
        AND date_x IS NOT NULL
'

EXEC sp_execute_external_script
    @language = N'R',
    @script = N'
        # Definir variables
        Y_data <- log(InputDataSet$revenue)
        Y_label <- "Ingresos (Escala Log)"
        X_data <- InputDataSet$score
        X_label <- "Calificación (Score)"
        
        plot_output_path <- image_path
        model <- lm(Y_data ~ X_data)
        
        png(plot_output_path, width = 800, height = 700, res = 100)
        plot(X_data, Y_data,
             main = "Regresión: Ingresos vs. Calificación",
             xlab = X_label,
             ylab = Y_label,
             pch = 16,
             col = rgb(0,0,0,0.3))
        abline(model, col = "green", lwd = 2)
        dev.off()

        model_summary <- summary(model)$coefficients
        OutputDataSet <- data.frame(Termino = row.names(model_summary), model_summary)
    ',
    @input_data_1 = @sql_query_reg2,
    @params = N'@image_path NVARCHAR(4000)', 
    @image_path = @ImagePathReg2

WITH RESULT SETS ((
    Termino NVARCHAR(100),
    Estimate FLOAT,
    Std_Error FLOAT,
    t_value FLOAT,
    Pr_t FLOAT
));
GO

/*
REGRESIÓN - CALIFICACIÓN vs. PRESUPUESTO 
*/

DECLARE @ImagePathReg3 NVARCHAR(4000) = N'C:\Principito\regresion_Calificacion_vs_Presupuesto.png';

DECLARE @sql_query_reg3 AS NVARCHAR(MAX)
SET @sql_query_reg3 = N'
    SELECT 
        budget_x, 
        revenue,
        score,
        YEAR(date_x) AS release_year
    FROM 
        IMDBProyecto.dbo.imdb_movies 
    WHERE 
        budget_x > 1000 
        AND revenue > 1000
        AND score > 0
        AND date_x IS NOT NULL
'

EXEC sp_execute_external_script
    @language = N'R',
    @script = N'
        # Definir variables
        Y_data <- InputDataSet$score
        Y_label <- "Calificación (Score)"
        X_data <- log(InputDataSet$budget_x)
        X_label <- "Presupuesto (Escala Log)"
        
        plot_output_path <- image_path
        model <- lm(Y_data ~ X_data)
        
        png(plot_output_path, width = 800, height = 700, res = 100)
        plot(X_data, Y_data,
             main = "Regresión: Calificación vs. Presupuesto",
             xlab = X_label,
             ylab = Y_label,
             pch = 16,
             col = rgb(0,0,0,0.3))
        abline(model, col = "purple", lwd = 2)
        dev.off()

        model_summary <- summary(model)$coefficients
        OutputDataSet <- data.frame(Termino = row.names(model_summary), model_summary)
    ',
    @input_data_1 = @sql_query_reg3,
    @params = N'@image_path NVARCHAR(4000)', 
    @image_path = @ImagePathReg3

WITH RESULT SETS ((
    Termino NVARCHAR(100),
    Estimate FLOAT,
    Std_Error FLOAT,
    t_value FLOAT,
    Pr_t FLOAT
));
GO

/*
REGRESIÓN - INGRESOS vs. AÑO DE ESTRENO 
*/

DECLARE @ImagePathReg4 NVARCHAR(4000) = N'C:\Principito\regresion_Ingresos_vs_Anio.png';

DECLARE @sql_query_reg4 AS NVARCHAR(MAX)
SET @sql_query_reg4 = N'
    SELECT 
        budget_x, 
        revenue,
        score,
        YEAR(date_x) AS release_year
    FROM 
        IMDBProyecto.dbo.imdb_movies 
    WHERE 
        budget_x > 1000 
        AND revenue > 1000
        AND score > 0
        AND date_x IS NOT NULL
'

EXEC sp_execute_external_script
    @language = N'R',
    @script = N'
        # Definir variables
        Y_data <- log(InputDataSet$revenue)
        Y_label <- "Ingresos (Escala Log)"
        X_data <- InputDataSet$release_year
        X_label <- "Año de Estreno"
        
        plot_output_path <- image_path
        model <- lm(Y_data ~ X_data)
        
        png(plot_output_path, width = 800, height = 700, res = 100)
        plot(X_data, Y_data,
             main = "Regresión: Ingresos vs. Año de Estreno",
             xlab = X_label,
             ylab = Y_label,
             pch = 16,
             col = rgb(0,0,0,0.3))
        abline(model, col = "orange", lwd = 2)
        dev.off()

        model_summary <- summary(model)$coefficients
        OutputDataSet <- data.frame(Termino = row.names(model_summary), model_summary)
    ',
    @input_data_1 = @sql_query_reg4,
    @params = N'@image_path NVARCHAR(4000)', 
    @image_path = @ImagePathReg4

WITH RESULT SETS ((
    Termino NVARCHAR(100),
    Estimate FLOAT,
    Std_Error FLOAT,
    t_value FLOAT,
    Pr_t FLOAT
));
GO