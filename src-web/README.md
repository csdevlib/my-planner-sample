# MyPlanner Web

## Descripción

MyPlanner Web es una aplicación de planificación de calendario con frontend en React + Vite y backend en Node.js + Express + MySQL. Permite crear, editar, guardar y cargar planes de calendario personalizados, con soporte para exportar a Excel y gestión de usuarios mediante contraseña.

---

## Tabla de Contenidos

- [Requisitos](#requisitos)
- [Instalación](#instalacion)
- [Ejecución](#ejecucion)
- [Linting y Formateo](#linting)
- [Estructura de Carpetas](#estructura)
- [Stack Tecnológico](#stack)
- [Comandos Útiles](#comandos)

---

<a name="requisitos"></a>

## 🚦 Requisitos

- Node.js 16 o superior
- NPM
- MySQL (para el backend)

---

<a name="instalacion"></a>

## 📦 Instalación

### 1. Clona el repositorio y entra a la carpeta principal

```bash
cd myplanner-web
```

### 2. Instala dependencias del frontend

```bash
npm install
```

### 3. Instala dependencias del backend

```bash
cd backend
npm install
```

---

<a name="ejecucion"></a>

## 🚀 Ejecución

### 1. Configura las variables de entorno

Crea un archivo `.env` en `backend/` con los datos de tu base de datos MySQL:

```
DB_HOST=localhost
DB_USER=tu_usuario
DB_PASS=tu_contraseña
DB_NAME=myplanner
PORT=3001
```

### 2. Inicia el backend

```bash
cd backend
node server.js
```

El backend estará disponible en `http://localhost:3001`.

### 3. Inicia el frontend

En otra terminal, desde la raíz del proyecto:

```bash
npm run dev
```

El sitio web estará disponible en `http://localhost:5173` (o el puerto que indique Vite).

---

<a name="linting"></a>

## 🧹 Linting y Formateo

Para corregir automáticamente los problemas de linting y formateo:

```bash
npx eslint . --fix
npm run lint
```

---

<a name="estructura"></a>

## 📁 Estructura de Carpetas

```
myplanner-web/
├── backend/           # Backend Node.js/Express
│   ├── server.js
│   ├── package.json
│   └── ...
├── src/               # Frontend React
│   ├── components/
│   ├── pages/
│   ├── services/
│   ├── hooks/
│   ├── models/
│   ├── utils/
│   └── ...
├── public/
├── package.json       # Frontend
├── vite.config.ts
└── ...
```

---

<a name="stack"></a>

## 🛠️ Stack Tecnológico

- **Frontend:** React, Vite, TypeScript, Tailwind CSS, Axios, React Query
- **Backend:** Node.js, Express, MySQL, bcrypt
- **Testing:** Jest, React Testing Library
- **Linting:** ESLint, Prettier, Husky, Lint-staged

---

<a name="comandos"></a>

## 📝 Comandos Útiles

- `npm run dev` — Inicia el frontend en modo desarrollo
- `npm run build` — Compila el frontend para producción
- `npm run lint` — Ejecuta el linter en el frontend
- `npm run test` — Ejecuta los tests
- `node server.js` — Inicia el backend

---

## Notas

- El backend expone las rutas `/api/calendar-plan/save` y `/api/calendar-plan/load` para guardar y cargar planes.
- El frontend se comunica automáticamente con el backend usando proxy en desarrollo.
- Puedes exportar tu plan a Excel desde la interfaz web.

---

¡Listo! Ahora puedes usar y modificar MyPlanner Web según tus necesidades.
