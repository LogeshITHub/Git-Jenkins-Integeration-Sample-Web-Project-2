/* wwwroot/js/site.js */
document.addEventListener("DOMContentLoaded", function () {
  // Check for saved dark mode preference
  const savedMode = localStorage.getItem("darkMode");
  if (savedMode === "enabled") {
    document.body.classList.add("dark-mode");
  }

  // Dark mode toggle button
  const toggleBtn = document.getElementById("darkModeToggle");
  if (toggleBtn) {
    toggleBtn.addEventListener("click", function () {
      document.body.classList.toggle("dark-mode");
      const isDarkMode = document.body.classList.contains("dark-mode");
      localStorage.setItem("darkMode", isDarkMode ? "enabled" : "disabled");
    });
  }

  // Any additional interactivity can be added here
});
