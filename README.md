# Análisis de Datos IMDB: Correlación y Regresión Lineal

Este proyecto es una aplicación de escritorio desarrollada en C# que realiza análisis de minería de datos sobre una base de datos de películas (IMDB). Permite visualizar la relación entre variables como Presupuesto, Ingresos, Calificación y Año mediante matrices de correlación y regresión lineal simple.

## 📊 Vistazo del Proyecto

El sistema genera visualizaciones estadísticas como estas:

![Matriz de Correlación](matriz_correlacion_COMPLETA.png)

### Ejemplos de Regresiones Generadas:

| Ingresos vs Presupuesto | Ingresos vs Calificación |
| :---: | :---: |
| ![Regresion](regresion_Ingresos_vs_Presupuesto.png) | ![Regresion](regresion_Ingresos_vs_Calificacion.png) |

---

## 📋 Requisitos Previos

Para ejecutar este proyecto en tu computadora necesitas:

- *Sistema Operativo:* Windows 10 u 11.  
- *Base de Datos:* SQL Server (Cualquier versión: Express, Developer, etc.).  
- *Framework:* .NET Framework 4.7.2 o superior.  
- *Entorno (Opcional):* Visual Studio 2019/2022 (si deseas modificar el código).  

---

## ⚙ Guía de Instalación (Paso a Paso)

Si descargaste este proyecto en otra computadora, sigue estos pasos para configurarlo:

### 1. Configurar la Base de Datos

El proyecto incluye un script para recrear la base de datos automáticamente.

1. Abre *SQL Server Management Studio (SSMS)*.
2. Abre el archivo `ProyectoFinalMineria.sql` (que se encuentra en la carpeta principal de este repositorio).
3. Presiona el botón *Execute (Ejecutar)* o la tecla F5.

> Esto creará la base de datos y cargará los datos necesarios.

### 2. Configurar la Conexión

Para que el programa encuentre TU servidor SQL local:

1. Ve a la carpeta del código fuente (`ProyectoFinal/ProyectoFinal`).
2. Busca y abre el archivo `App.config` con el Bloc de Notas.
3. Busca la línea que dice `<connectionStrings>`.
4. Cambia la parte de `Data Source` por el nombre de tu servidor:

```xml
<add name="CadenaConexion" connectionString="Data Source=.;Initial Catalog=IMDBProyecto;Integrated Security=True" providerName="System.Data.SqlClient" />
```

---

## 🚀 Cómo Ejecutar el Proyecto

Tienes dos formas de abrir la aplicación:

### ✅ Opción A: Ejecutable Directo (Sin abrir código)

Si solo quieres usar el programa rápidamente:

1. Navega a la carpeta: `ProyectoFinal/ProyectoFinal/bin/Debug/`.
2. Busca el archivo ejecutable `.exe` (generalmente con el icono de la aplicación).
3. ¡Doble clic y listo!

**Nota:** Si aparece un error, asegúrate de haber editado el archivo `.config` que está junto al `.exe`.

### 🧑‍💻 Opción B: Desde Visual Studio (Para desarrolladores)

1. Abre el archivo de solución `.sln`.
2. Presiona el botón **Iniciar (Start)** en la barra superior.

---

## 🛠 Tecnologías Usadas

- Lenguaje: C# (.NET)  
- Base de Datos: SQL Server (T-SQL)  
- Interfaz: Windows Forms  
- Librerías:  
  - `System.Windows.Forms.DataVisualization` (para las gráficas)
