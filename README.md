# :green_salad: The Kitchen Mess

![](https://github.com/Hayley96/TheKitchenMess/blob/a22bed67a717df2b4fc774b4f28e8a768b7b57bf/Banner.png)

## :link: Table of contents
1. [Introduction](#introduction)
2. [Application Overview](#applicationOverview)
   1. [Technologies Used](#technologiesUsed)
   2. [Application Design](#applicationDesign)
   3. [API Reference](#APIReference)
3. [Getting Started](#gettingStarted)
    1. [Pre-requisites](#prerequisites)
    2. [Environment Variables](#environmentVariables)


## Introduction :wave: <a name="introduction"></a>
An API app designed to return recipe information based on a specified set of include/exclude ingredients and a maximum number of calories. The app makes use of the Spoonacular Public API: [https://spoonacular.com/food-api](https://spoonacular.com/food-api)

## :computer: Application Overview <a name="applicationOverview"></a>

### ⚒️ Technologies Used <a name="technologiesUsed"></a>

<div>
<img align="left" alt="C#" title="C-Sharp" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
<img align="left" alt=".NET 6" title=".NET 6" src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
<img align="left" alt="ASP.NET MVC 6 (Web API)" title="ASP.NET MVC 6 (Web API)" src="https://img.shields.io/badge/-ASP.NET%20Core-fff?style=for-the-badge&logo=.net&logoColor=blue" />
<img align="left" alt="EntityFramework" title="MS EntityFramework Core 6" src="https://img.shields.io/badge/-Entity_Framework_Core-fff?style=for-the-badge&logo=Microsoft&logoColor=0078D7" />
<img align="left" alt="PostGreSQL"  src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white" />
<img align="left" alt="JSON"  src="https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white" />
</div>
</br></br>
<div>
<img align="left" alt="Swagger"  src="https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white" />
</div>
</br></br>

### 💡 Application Design <a name="applicationDesign"></a>

Class Diagram: 

![TheKitchenMessArchitecture](https://github.com/Hayley96/TheKitchenMess/blob/main/TheKitchenMessApp%20UML%20Final.png)

### 🔄 API Reference <a name="APIReference"></a>

#### Get all recipes

```http
  GET /api/v1/recipe
```

| Parameter | Type       | Description                                                       |
| :-------- | :----------| :-----------------------------------------------------------------|
| `calories` | `integer` | **Required**. The maximum number of calories a recipe should have |

#### Get all recipes containing a set of ingredients

```http
  GET /api/v1/recipe/${ingredients}
```

| Parameter     | Type       | Description                                                       |
| :------------ | :----------| :-----------------------------------------------------------------|
| `calories`    | `integer`  | **Required**. The maximum number of calories a recipe should have |
| `ingredients` | `string`   | **Required**. The list of ingredients a recipe should include     |

#### Get all recipes containing a set of ingredients whilst excluding another set of ingredients

```http
  GET /api/v1/recipe/${ingredients}{exingredients}
```

| Parameter       | Type       | Description                                                       |
| :---------------| :----------| :-----------------------------------------------------------------|
| `calories`      | `integer`  | **Required**. The maximum number of calories a recipe should have | 
| `ingredients`   | `string`   | **Required**. The list of ingredients a recipe should include     |
| `exIngredients` | `string`   | **Required**. The list of ingredients a recipe should not include |

API Endpoint User stories:

<p float="left" align="middle">
  <img title="Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes%20Final.png" width="32%" Height="32%" />
  <img title="Ingredients and Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes%20Using%20Ingredients%20Final.png" width="32%"  Height="32%" /> 
  <img title="Include/Exclude Ingredients and Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes%20Using%20Ingredients%20ExclIngred.png" width="32%" Height="32%" />
</p>

## 🔀 Getting Started <a name="gettingStarted"></a>

### Pre-requisites <a name="prerequisites"></a>

* C# / .NET 6
* NuGet
* Spoonacular API Key. You can sign up for a free account to obtain an API Key [here:](https://spoonacular.com/food-api)
* PostGreSQL

### Environment Variables <a name="environmentVariables"></a>

To run this project, you will need to add the following environment variables to your .env file

`SpoonacularKey` - the API key provided by Spoonacular when creating an account

`KitchenMessAPI` - the connection string details to your PostGreSQL DB instance

//IN PROGRESS
