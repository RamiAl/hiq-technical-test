# Frontend: File Processing Application

This project is a **Vite-based** frontend designed to upload files to a backend for processing, retrieve the results, and display them in a clear and intuitive way. Leveraging modern web technologies, it provides a seamless user experience and fast development workflow.


## Overview

Key functionalities and features include:
- **File Upload**: Users can select and upload files (e.g., text files) for processing.
- **Live Feedback**: Real-time status updates during file processing.
- **Results Display**: Clean and organized presentation of processed file data.


## Prerequisites

- **Node.js (v18.0.0 or higher)** is required to run and build this project.

If you need to install or upgrade Node.js, visit the [official Node.js website](https://nodejs.org/) or use a version manager like [nvm](https://github.com/nvm-sh/nvm).

---

## Getting Started

Follow the steps below to set up and run this project locally for development and testing:

### 1. Install Dependencies
```bash
npm install
```

### 2. Run the Development Server
```bash
npm run dev
```
By default, this starts a local development server accessible at http://localhost:5173.


### 3. Building for Production
To create an optimized production build, run:
```bash
npm run build
```
This generates a dist folder containing minified, ready-to-deploy assets. You can host these files on any static server or platform (e.g., AWS S3, Netlify, Vercel, GitHub Pages, etc.).


### Additional Configuration
Environment Variables (Optional): If you need to point to a specific backend endpoint or set other configuration values, you can create a .env file and define variables with the VITE_ prefix (e.g., VITE_API_URL). Access them in your code with import.meta.env.VITE_API_URL.