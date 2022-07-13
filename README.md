# :green_salad: The Kitchen Mess

![](https://github.com/Hayley96/TheKitchenMess/blob/a22bed67a717df2b4fc774b4f28e8a768b7b57bf/Banner.png)

## Introduction :wave:
An API app designed to return recipe information based on a specified set of include/exclude ingredients and a maximum number of calories. The app makes use of the Spoonacular Public API: [https://spoonacular.com/food-api](https://spoonacular.com/food-api)

### 💻 Technologies Used

<p float="left">
<img align="left" alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
<img align="left" alt=".NET 6" src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
<img align="left" alt="PostGreSQL"  src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white" />
<img align="left" alt="JSON"  src="https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white" />
<img align="left" alt="Swagger"  src="https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white" />
<img align="left" alt="Visual Studio" src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white" />
</p>
</br>

### 💡 Application Design 

Application Class Diagram: 

![TheKitchenMessArchitecture](https://github.com/Hayley96/TheKitchenMess/blob/main/TheKitchenMessApp%20UML.png)

## API Reference

#### Get all recipes

```http
  GET /api/v1/recipe
```

| Parameter | Type       | Description                                                       |
| :-------- | :----------| :-----------------------------------------------------------------|
| `calories` | `integer` | **Required**. The maximum number of calories a recipe should have |

#### Get all recipes containing a set of ingredients

```http
  GET /api/v1/recipe{ingredients}
```

| Parameter     | Type       | Description                                                       |
| :------------ | :----------| :-----------------------------------------------------------------|
| `calories`    | `integer`  | **Required**. The maximum number of calories a recipe should have |
| `Ingredients` | `string`   | **Required**. The list of ingredients a recipe should include     |

#### Get all recipes containing a set of ingredients whilst excluding another set of ingredients

```http
  GET /api/v1/recipe{ingredients} {exingredients}
```

| Parameter       | Type       | Description                                                       |
| :---------------| :----------| :-----------------------------------------------------------------|
| `calories`      | `integer`  | **Required**. The maximum number of calories a recipe should have | 
| `Ingredients`   | `string`   | **Required**. The list of ingredients a recipe should include     |
| `ExIngredients` | `string`   | **Required**. The list of ingredients a recipe should not include |

User stories for each of the GET Recipe API Endpoints:

<p float="left" align="middle">
  <img title="Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes.png" width="32%" Height="32%" />
  <img title="Ingredients and Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes%20Using%20Ingredients.png" width="32%"  Height="32%" /> 
  <img title="Include/Exclude Ingredients and Calories Only Endpoint" src="https://github.com/Hayley96/TheKitchenMess/blob/main/User%20Story%20Get%20Recipes%20Using%20Ingredients%20and%20Exclude%20Ingredients.png" width="32%" Height="32%" />
</p>

//IN PROGRESS
