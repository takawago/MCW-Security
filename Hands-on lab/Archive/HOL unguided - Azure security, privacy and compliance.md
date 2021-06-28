![](https://github.com/Microsoft/MCW-Template-Cloud-Workshop/raw/master/Media/ms-cloud-workshop.png "Microsoft Cloud Workshops")

<div class="MCWHeader1">
Security baseline on Azure
</div>

<div class="MCWHeader2">
Hands-on lab unguided
</div>

<div class="MCWHeader3">
March 2019
</div>

Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious, and no association with any real company, organization, product, domain name, e-mail address, logo, person, place or event is intended or should be inferred. Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

The names of manufacturers, products, or URLs are provided for informational purposes only, and Microsoft makes no representations and warranties, either expressed, implied, or statutory, regarding these manufacturers or the use of the products with any Microsoft technologies. The inclusion of a manufacturer or product does not imply endorsement of Microsoft of the manufacturer or product. Links may be provided to third-party sites. Such sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement of Microsoft of the site or the products contained therein.

© 2019 Microsoft Corporation. All rights reserved.

Microsoft and the trademarks listed at <https://www.microsoft.com/en-us/legal/intellectualproperty/Trademarks/Usage/General.aspx> are trademarks of the Microsoft group of companies. All other trademarks are property of their respective owners.

**Contents** 

<!-- TOC -->

- [Security baseline on Azure hands-on lab unguided](#Security-baseline-on-Azure-hands-on-lab-unguided)
    - [Abstract and learning objectives](#abstract-and-learning-objectives)
    - [Overview](#overview)
    - [Solution architecture](#solution-architecture)
    - [Requirements](#requirements)
    - [Exercise 1: Implementing Just-In-Time (JIT) access](#exercise-1-implementing-just-in-time-jit-access)
        - [Task 1: Setup virtual machines with JIT](#task-1-setup-virtual-machines-with-jit)
            - [Tasks to Complete:](#tasks-to-complete)
            - [Exit Criteria:](#exit-criteria)
        - [Task 2: Perform a JIT request](#task-2-perform-a-jit-request)
            - [Tasks to Complete:](#tasks-to-complete-1)
            - [Exit Criteria:](#exit-criteria-1)
    - [Exercise 2: Securing the Web Application and Database](#exercise-2-securing-the-web-application-and-database)
        - [Task 1: Setup the database](#task-1-setup-the-database)
            - [Tasks to Complete:](#tasks-to-complete-2)
            - [Exit Criteria:](#exit-criteria-2)
        - [Task 2: Test the web application solution](#task-2-test-the-web-application-solution)
            - [Tasks to Complete:](#tasks-to-complete-3)
            - [Exit Criteria:](#exit-criteria-3)
        - [Task 3: Utilize data masking](#task-3-utilize-data-masking)
            - [Tasks to Complete:](#tasks-to-complete-4)
            - [Exit Criteria:](#exit-criteria-4)
        - [Task 4: Utilize column encryption with Azure key vault](#task-4-utilize-column-encryption-with-azure-key-vault)
            - [Tasks to Complete:](#tasks-to-complete-5)
            - [Exit Criteria:](#exit-criteria-5)
    - [Exercise 3: Migrating to Azure Key Vault](#exercise-3-migrating-to-azure-key-vault)
        - [Task 1: Create an Azure Key Vault secret](#task-1-create-an-azure-key-vault-secret)
            - [Tasks to Complete:](#tasks-to-complete-6)
            - [Exit Criteria:](#exit-criteria-6)
        - [Task 2: Create an Azure Active Directory application](#task-2-create-an-azure-active-directory-application)
            - [Tasks to Complete:](#tasks-to-complete-7)
            - [Exit Criteria:](#exit-criteria-7)
        - [Task 3: Assign Azure Active Directory application permissions](#task-3-assign-azure-active-directory-application-permissions)
            - [Tasks to Complete:](#tasks-to-complete-8)
            - [Exit Criteria:](#exit-criteria-8)
        - [Task 4: Install or verify nuget package](#task-4-install-or-verify-nuget-package)
            - [Tasks to Complete:](#tasks-to-complete-9)
            - [Exit Criteria:](#exit-criteria-9)
        - [Task 5: Test the Solution](#task-5-test-the-solution)
            - [Tasks to Complete:](#tasks-to-complete-10)
            - [Exit Criteria:](#exit-criteria-10)
    - [Exercise 4: Securing the Network](#exercise-4-securing-the-network)
        - [Task 1: Test network security groups \#1](#task-1-test-network-security-groups-\1)
            - [Tasks to Complete:](#tasks-to-complete-11)
            - [Exit Criteria:](#exit-criteria-11)
        - [Task 2: Configure network security groups](#task-2-configure-network-security-groups)
            - [Tasks to Complete:](#tasks-to-complete-12)
            - [Exit Criteria:](#exit-criteria-12)
        - [Task 3: Test network security groups \#2](#task-3-test-network-security-groups-\2)
            - [Tasks to Complete:](#tasks-to-complete-13)
            - [Exit Criteria:](#exit-criteria-13)
        - [Task 4: Install network watcher VM extension](#task-4-install-network-watcher-vm-extension)
            - [Tasks to Complete:](#tasks-to-complete-14)
            - [Exit Criteria:](#exit-criteria-14)
        - [Task 5: Setup network packet capture](#task-5-setup-network-packet-capture)
            - [Tasks to Complete:](#tasks-to-complete-15)
            - [Exit Criteria:](#exit-criteria-15)
        - [Task 6: Execute a port scan](#task-6-execute-a-port-scan)
            - [Tasks to Complete:](#tasks-to-complete-16)
            - [Exit Criteria:](#exit-criteria-16)
    - [Exercise 5: Creating security log alerts](#exercise-5-creating-security-log-alerts)
        - [Task 1: Create a custom alert](#task-1-create-a-custom-alert)
            - [Tasks to Complete:](#tasks-to-complete-17)
            - [Exit Criteria:](#exit-criteria-17)
        - [Task 2: Investigate a custom alert](#task-2-investigate-a-custom-alert)
            - [Tasks to Complete:](#tasks-to-complete-18)
            - [Exit Criteria:](#exit-criteria-18)
        - [Task 3: Create and run a playbook](#task-3-create-and-run-a-playbook)
            - [Tasks to Complete:](#tasks-to-complete-19)
            - [Exit Criteria:](#exit-criteria-19)
    - [Exercise 6: Creating Compliance Reports with Power BI](#exercise-6-creating-compliance-reports-with-power-bi)
        - [Task 1: Export a Power Query formula from Log Analytics](#task-1-export-a-power-query-formula-from-log-analytics)
            - [Tasks to Complete:](#tasks-to-complete-20)
            - [Exit Criteria:](#exit-criteria-20)
    - [Exercise 7: Using Compliance Manager](#exercise-7-using-compliance-manager)
        - [Task 1: Use Compliance Manager for Azure](#task-1-use-compliance-manager-for-azure)
            - [Tasks to Complete:](#tasks-to-complete-21)
            - [Exit Criteria:](#exit-criteria-21)
    - [After the Hands-on Lab](#after-the-hands-on-lab)
        - [Task 1: Delete resource group](#task-1-delete-resource-group)

<!-- /TOC -->

# Security baseline on Azure hands-on lab unguided 

## Abstract and learning objectives 

In this hands-on lab, you will implement many of the Azure Security Center features to secure their cloud-based Azure infrastructure (IaaS) and applications (PaaS). Specifically, you will ensure that any internet exposed resources have been properly secured and any non-required internet access disabled. Additionally, you will implement a “jump machine” for admins. with Application Security enabled to prevent admins from installing non-approved software and potentially exposing cloud resources. You will then utilize custom alerts to monitor for TCP/IP Port Scans and then fire alerts and run books based on those attacks.

At the end of this hands-on lab, you will be better able to design and build secure cloud-based architectures, and to improve the security of existing applications hosted within Azure.

## Overview

Contoso is a multinational corporation, headquartered in the United States that provides insurance solutions worldwide. Its products include accident and health insurance, life insurance, travel, home, and auto coverage. Contoso manages data collection services by sending mobile agents directly to the insured to gather information as part of the data collection process for claims from an insured individual. These mobile agents are based all over the world and are residents of the region in which they work. Mobile agents are managed remotely, and each regional corporate office has a support staff responsible for scheduling their time based on requests that arrive to the system.??

They are migrating many of their applications via Lift and Shift to Azure and would like to ensure that they can implement the same type of security controls and mechanisms they currently have. They would like to be able to demonstrate their ability to meet compliance guidelines required in the various countries/regions they do business. They have already migrated a web application and database server to their Azure instance and would like to enable various logging and security best practices for administrator logins, SQL Databases, and virtual network design.

## Solution architecture

Contoso administrators recently learned about the Azure Security Center and have decided to implement many of its features to secure their cloud-based Azure infrastructure (IaaS) and applications (PaaS). Specifically, they want to ensure that any internet exposed resources have been property secured and any non-required internet access disabled. They also decided that implementing a "jump machine" for admins with Application Security was also important as they had admins installing non-approved software on their machines and then accessing cloud resources. They also want the ability to be alerted when TCP/IP Port Scans are detected and fire alerts based on those attacks.

![This diagram shows external access to Azure resources where Just In Time is utilize to lock down the Jump Machine. Azure Log Analytics is then used to monitor the deny events on the network security groups.](images/Hands-onlabunguided-Azuresecurity,privacyandcomplianceimages/media/image2.png)

The solution begins by creating a jump machine. This jump machine is used to access the virtual machines and other resources in the resource group. All other access is disabled via multiple **virtual networks**. More than one virtual network is required as having a single **virtual network** would cause all resource to be accessible based on the default currently un-customizable security group rules. Resources are organized into these virtual networks. **Azure Center Security** is utilized to do **Just-In-Time** access to the jump machine. This ensures that all access is audited to the jump machine and that only authorized IP-addressed are allowed access, this prevents random attacks on the virtual machines from bad internet actors. Additionally, applications are not allowed to be installed on the jump machine to ensure that malware never becomes an issue. Each of the virtual network and corresponding **network security groups** have logging enabled to record deny events to **Azure Logging**. These events are then monitored by a **custom alert rule** in **Azure Security Center** to fire **custom alerts** which then execute custom **Azure Runbooks**. Once the solution is in place, the **Compliance Manager** tool is utilized to ensure that all GDPR based technical and business controls are implemented and maintained to ensure GDPR compliance.

## Requirements

1.  Microsoft Azure subscription must be pay-as-you-go or MSDN.

    a.  Trial subscriptions will not work.

2.  A machine with the following software installed:

    b.  Visual Studio 2017

    c.  SQL Management Studio 2017

    d.  Power BI Desktop

## Exercise 1: Implementing Just-In-Time (JIT) access

Duration: 15 minutes

Synopsis: In this exercise, attendees will secure a Privileged Access Workstation (PAW) workstation using the Azure Security Center Just-In-Time Access feature.

### Task 1: Setup virtual machines with JIT

#### Tasks to Complete:

-   Setup the PAW-1 Virtual Machine with JIT Access.

#### Exit Criteria:

-   JIT security rules setup on NSG for PAW-1.

### Task 2: Perform a JIT request

#### Tasks to Complete:

-   Submit a request to activate the JIT.

-   Login to the PAW-1 VM via RDP.

#### Exit Criteria:

-   Successful login to the PAW-1 machine.

## Exercise 2: Securing the Web Application and Database

Duration: 45 minutes

Synopsis: In this exercise, attendees will utilize Azure SQL features to data mask database data and utilize Azure Key Vault to encrypt sensitive columns for users and applications that query the database.

### Task 1: Setup the database

#### Tasks to Complete:

-   Restore the Insurance.bacpac file to the Azure SQL Server setup in your Azure tenant.

-   Create a user called agent that has db\_reader access to the Insurance database.

#### Exit Criteria:

-   Insurance database exists in your Azure Tenant.

-   The agent user can be used to connect to the database using SQL Management Studio.

### Task 2: Test the web application solution

#### Tasks to Complete:

-   Open the InsuranceAPI solution.

-   Modify the web.config file to point to your new Insurance database.

#### Exit Criteria:

-   Run the web application, navigation to [http://localhost:postno/api/Users](http://localhost:postno/api/Users). You should see unmasked data displayed.

### Task 3: Utilize data masking

#### Tasks to Complete:

-   Configure the Azure DB User table, SSN column to have data masking.

#### Exit Criteria:

-   Refresh the [http://localhost:postno/api/Users](http://localhost:postno/api/Users) page. You should see data displayed but the SSN should be masked.

### Task 4: Utilize column encryption with Azure key vault

#### Tasks to Complete:

-   Configure the SSN column to utilize Azure Key Vault for column encryption.

#### Exit Criteria:

-   Execute a "select \* from User" SQL Management Query that shows the SSN column as encrypted.

## Exercise 3: Migrating to Azure Key Vault

Duration: 30 minutes

Synopsis: In this exercise, attendees will learn how to migrate web application to utilize Azure Key Vault rather than storing valuable credentials (such as connection strings) in application configuration files.

### Task 1: Create an Azure Key Vault secret

#### Tasks to Complete:

-   Open the InsuranceAPI\_KeyVault solution.

-   Migrate the connection string to an Azure Key Vault secret.

#### Exit Criteria:

-   Azure Key Vault secret exists with connection string.

### Task 2: Create an Azure Active Directory application

#### Tasks to Complete:

-   Create a new Azure AD application.

#### Exit Criteria:

-   A new Azure AD application exists.

### Task 3: Assign Azure Active Directory application permissions

#### Tasks to Complete:

-   Assign the Azure AD application with access to the Azure Key Vault secret.

#### Exit Criteria:

-   Azure AD application has proper permissions to gain access to key vault.

### Task 4: Install or verify nuget package

#### Tasks to Complete:

-   Ensure that the Microsoft.IdentityModel.Clients.ActiveDirectory and Microsoft.Azure.KeyVault nuget packages exist for the project.

#### Exit Criteria:

-   Successful web application complied.

### Task 5: Test the Solution

#### Tasks to Complete:

-   Configure the web app to utilize an Azure AD clientId and secret to gain access to the Azure Key Vault secret for the EntityFramework ConnectionString.

#### Exit Criteria:

-   Web Application utilizes Azure AD application to gain access token.

-   Web Application uses access token to download the Azure Key Vault secret.

-   Data is successfully displayed on the [http://localhost:portno/api/Users](http://localhost:portno/api/Users) page.

## Exercise 4: Securing the Network

Duration: 45 minutes

Synopsis: In this exercise, attendees will utilize Network Security Groups to ensure that virtual machines are segregated from other Azure hosted services and then explore the usage of the Network Packet Capture feature of Azure to actively monitor traffic between networks.

### Task 1: Test network security groups \#1

#### Tasks to Complete:

-   Connect to the PAW-1 machine over RDP.

-   Using the PortScanner.ps1 file, check the allowed ports between the PAW-1, DB-1 and WEB-1 machines.

#### Exit Criteria:

-   Understanding of current NSG environment.

### Task 2: Configure network security groups

#### Tasks to Complete:

-   Configure the DbTrafficOnly NSG to allow 1433 traffic from the WEB-1 Virtual Machine.

-   Configure the WebTrafficOnly NSG to allow 80,443 traffic from any where.

-   Configure the DbTrafficOnly and WebTrafficOnly NSG to allow RDP access from the PAW-1 virtual machine.

#### Exit Criteria:

-   RDP traffic can only come from the PAW-1 machine for WEB-1 and DB-1.

-   Web Traffic is allowed to WEB-1.

-   SQL Traffic is allowed from WEB-1 to DB-1.

### Task 3: Test network security groups \#2

#### Tasks to Complete:

-   Execute a Port Scan from PAW-1 using the PortScanner.ps1 script. This can also be used to test your port configurations.

#### Exit Criteria:

-   RDP traffic can only come from the PAW-1 machine for WEB-1 and DB-1.

-   Web Traffic is allowed to WEB-1.

-   SQL Traffic is allowed from WEB-1 to DB-1.

### Task 4: Install network watcher VM extension

#### Tasks to Complete:

-   Install the Network Watcher VM Extension on DB-1.

#### Exit Criteria:

-   VM extension is installed successfully on DB-1.

### Task 5: Setup network packet capture

#### Tasks to Complete:

-   Setup a Network Packet Capture on DB-1.

#### Exit Criteria:

-   A packet capture file is saved to the storage account.

### Task 6: Execute a port scan

#### Tasks to Complete:

-   Execute a port scan from PAW-1 to both WEB-1 and DB-1.

#### Exit Criteria:

-   At least 400 different ports scanned across both machines.

## Exercise 5: Creating security log alerts

Duration: 20 minutes

Synopsis: In this exercise, you will create custom security alerts using the Azure Security Center. The alert will generate the execution of a RunBook using Logic Apps.

### Task 1: Create a custom alert

#### Tasks to Complete:

-   Create a custom alert called PortScans that will monitor for all inbound blocking operations on the WebTrafficOnly NSG. The period should be one hour, evaluated every 30 minutes with a threshold of 100.

#### Exit Criteria:

-   A custom alert that picks up all blocked traffic to the WebTrafficOnly NSG.

### Task 2: Investigate a custom alert

#### Tasks to Complete:

-   After an alert is fired, review it using the Azure Security Center.

#### Exit Criteria:

-   A reviewed security center alert.

### Task 3: Create and run a playbook

#### Tasks to Complete:

-   Create a RunBook based on the alert that will send an email on alert.

#### Exit Criteria:

-   A custom alert that picks up all blocked traffic to the WebTrafficOnly NSG with an Email action/RunBook logic app.

## Exercise 6: Creating Compliance Reports with Power BI

Duration: 15 minutes

Synopsis: In this exercise, attendees will learn to navigate the Compliance Manager to explore the various documents that describe the compliance and trust.

### Task 1: Export a Power Query formula from Log Analytics

#### Tasks to Complete:

-   Export a log analytics query from the Log Analytics portal.

-   Import the query into Power BI.

#### Exit Criteria:

-   Power BI Desktop shows a query from log analytics.

## Exercise 7: Using Compliance Manager

Duration: 15 minutes

Synopsis: In this exercise, attendees will learn to navigate the Compliance Manager to explore the various documents that describe the compliance and trust.

### Task 1: Use Compliance Manager for Azure

#### Tasks to Complete:

-   Open the Microsoft Service Trust web site.

-   Create a new assessment for Azure and GDPR.

-   Find the FedRamp security assessment on the Service Trust site.

#### Exit Criteria:

-   A new compliance assessment is created.

-   You have the FedRamp security assessment for Azure displayed on your screen.

## After the Hands-on Lab 

Duration: 10 minutes

In this exercise, attendees will deprovision any Azure resources that were created in support of the lab.

### Task 1: Delete resource group

1.  Using the Azure portal, navigate to the Resource group you used throughout this hands-on lab by selecting Resource groups in the left menu

2.  Search for the name of your research group, and select it from the list.

3.  Select Delete in the command bar, and confirm the deletion by re-typing the Resource group name and selecting Delete.

