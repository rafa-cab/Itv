Sistema de Gestión de Vehículos ITV
Este proyecto consiste en el desarrollo de un sistema para la gestión de vehículos en una estación de ITV, permitiendo el almacenamiento multiformato, la exportación de datos y la gestión de copias de seguridad.
1. Modelo de Datos
Cada vehículo debe contener la siguiente información obligatoria:
Matrícula: Formato NNNNLLL (4 números y 3 letras). Nota: Es un campo único (unique), pero no se utiliza como Primary Key.
Marca
Modelo
Cilindrada
Tipo de Combustible: (Diesel, Gasolina, Híbrido, Eléctrico).
DNI del Dueño
2. Persistencia y Repositorio (CRUD)
El sistema debe implementar un repositorio CRUD con las siguientes características:
Listados: Debe soportar get all paginado.
Eliminación: Los delete se deben realizar mediante borrado lógico, no borrado físico.
Soportes de almacenamiento: El repositorio debe ser capaz de trabajar con:
Memoria (Runtime).
JSON.
Binario Secuencial (BinSec).
Binario de Acceso Aleatorio (BinRa).
3. Caché y Almacenamiento Externo
Caché Configurable: Implementación de una caché tipo LRU (Least Recently Used) con tamaño X a definir.
Importación/Exportación: Capacidad para procesar toda la información en los siguientes formatos:
CSV
JSON
XML
Binario Secuencial
4. Servicios Adicionales
Servicio de Backup: Servicio encargado de realizar copias de seguridad de los archivos.
Servicio de Validación: Un servicio que permite validar y gestionar toda la lógica de negocio.
Configuración: La configuración del sistema se debe gestionar a través de un archivo appsettings.
5. Notas de Implementación
Restricción de Matrícula: Aunque la matrícula es única para cada vehículo, el diseño especifica que no debe ser la Clave Primaria (Primary Key) de la base de datos o colección.
