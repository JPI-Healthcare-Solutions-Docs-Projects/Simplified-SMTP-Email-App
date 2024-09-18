# SMTP Email C# Application for JPI Healthcare Solutions

This application provides a simplified way to send emails using SMTP through C#. It leverages the **MimeKit** library to handle email creation and transmission securely and efficiently.

## Prerequisites

Before getting started, ensure you have the following:

1. **Visual Studio Community Edition**: Download and install the latest version from [here](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false).

   - During installation, select the **.NET desktop development** workload.

   ![Select .NET Development](https://github.com/chitangchin/Email-App/assets/96362668/b51f1208-93f9-410c-b278-56a5c9ca2156)

   - Once selected, click **Install** to begin the setup.

   ![Install Visual Studio](https://github.com/chitangchin/Email-App/assets/96362668/f972a7a7-0ff7-4772-b316-f971ca0f3171)

## Steps to Start the Application

Follow these steps to clone, set up, and run the application:

1. **Open Visual Studio**: Launch Visual Studio 2022 (or a compatible version).
2. **Clone the Repository**: In the Visual Studio start window, select **Clone a repository**.

   ![Clone a Repository](https://github.com/chitangchin/Simplified-SMTP-Email-App/assets/96362668/87a9535a-5a09-45d3-aafe-de7b5f453ece)

3. **Enter Repository URL**: Paste the following URL in the clone window:
   
``` bash
https://github.com/chitangchin/Simplified-SMTP-Email-App.git
```


4. **Configure Project Settings**: Once the project is cloned successfully, navigate to **Solution Explorer**, right-click on **ExamVue Duo Email App**, and select **Properties**.

![Right-click Properties](https://github.com/chitangchin/Simplified-SMTP-Email-App/assets/96362668/68fa10c4-488c-4b02-bd3c-5ed854495537)

5. **Modify Signing Settings**:
- Go to the **Signing** tab.
- Uncheck **Sign the ClickOnce manifests** option to avoid issues during build.

![Uncheck Signing](https://github.com/chitangchin/Simplified-SMTP-Email-App/assets/96362668/c50c9fa4-500a-4815-951e-53a2bbde9171)

6. **Build the Application**: Press `Ctrl + B` to build the project. This compiles the application and ensures all dependencies are ready.

7. **Run the Application**: Click the **Start** button (or press `F5`) to run the application.

![Start Application](https://github.com/chitangchin/Simplified-SMTP-Email-App/assets/96362668/4b86ce08-2be8-445e-85af-110eaa834a8e)

### You're Now Ready to Test the Simplified Email Function

Once the application is running, you can begin sending test emails using **MimeKit**. The application is designed to streamline the email-sending process, making it easy to integrate SMTP functionality into your projects.

---

## Key Features

- **Simplified Email Sending**: The app provides an intuitive interface to quickly send emails using SMTP with minimal configuration.
- **MimeKit Integration**: It utilizes MimeKit for email formatting and transmission, ensuring emails adhere to standard protocols.
- **Customizable Settings**: Modify SMTP server settings, sender information, and email content within the app.

---

## Contribution

Feel free to fork the repository and submit pull requests to contribute to this project. If you encounter issues or bugs, please open an issue in the repository.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
