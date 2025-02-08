## 1. How long time did you end up spending on this coding test?

I spent approximately **4 hours** in total on this coding test, which included:
- Setting up the solution structure - frontend and backend.
- Implementing the file upload and text-processing logics.
- Creating brief READMEs and instructions for running the application.

## 2. Explain why you chose the code structure(s) you used in your solution.
- **Backend (ASP.NET Core)**  
  I followed the default .NET template to keep things straightforward and clear. This approach makes it easy to add more controllers or services in the future. By separating responsibilities into folders like `Controllers` and `Services`, I can keep the code organized and maintainable.

- **Frontend (Vite + Vue.js)**  
  I picked Vite because it offers a very fast development workflow, and Vue.js is intuitive for building user interfaces. Keeping my Vue components in a `src` folder helps keep the project structure neat and scalable.

## 3. What would you add to your solution if you had more time?

If I had more time, I would:
1. **Implement Authentication**: Secure the file upload endpoint and process only authorized requests.
2. **Implement More Robust Error Handling**: Better error messages and provide fallback logic for edge cases such as very large files or invalid text formats. 
3. **Improve Frontend UI**: Improve styling; show loading while the file is being processed and more detailed feedback about the results.
4. **Continuous Integration (CI)**: Run tests and building checks for every commit using a service like GitHub Actions or Azure DevOps. 
5. **Deployment Scripts**: Include Docker or other scripts to easily deploy both frontend and backend.
6. **Separate Repositories for Backend and Frontend**: So that each team might work independently and manage versions, releasing new features independently without causing interference with the other codebase.

## 4. What did you think of this recruitment test?

I found the recruitment test to be quite practical for demonstrating full-stack skills. It provided a clear, self-contained task with file processing, which allowed showing how to structure a solution, write straightforward business logic, and handle file uploads. Also, integrating both a frontend and a backend in one repository allowed me to show how these layers might talk to each other.
