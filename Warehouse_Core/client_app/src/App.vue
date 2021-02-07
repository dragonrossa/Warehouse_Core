<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/warehouse.png" />
    <HelloWorld msg="Welcome to Warehouse" />
    <p>{{option0}}</p>
   <p>
      <router-link to="/admin">{{ option1 }}</router-link>
    </p>
    <p>
      <router-link to="/storage">{{ option2 }}</router-link>
    </p>
    <p>
      <router-link to="/logs">{{ option3 }}</router-link>
    </p>
    <p>
      <router-link to="/procurement">{{ option4 }}</router-link>
    </p>
    <p>
      <router-link to="/search">{{ option5 }}</router-link>
    </p>
    <p>
      <router-link to="/store">{{ option6 }}</router-link>
    </p>
    <p>
      <router-link to="/suppliers">{{ option7 }}</router-link>
    </p>
    <p>
      <router-link to="/task">{{ option8 }}</router-link>
    </p>
    <p>
      <router-link to="/transfers">{{ option9 }}</router-link>
    </p>
    <p>
      <router-link to="/users">{{ option10 }}</router-link>
    </p>
  </div>
</template>

<script>
import HelloWorld from "./components/StartPage.vue";

export default {
  name: "App",
  components: {
    HelloWorld,
  },
  data() {
    return {
      option0: "Choose from default options:",
      option1: "Admin panel",
      option2: "Storage",
      option3: "Logs",
      option4: "Procurement",
      option5: "Search",
      option6: "Store",
      option7: "Suppliers",
      option8: "Task",
      option9: "Transfers",
      option10: "Users",
    };
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
  margin-top: 60px;
  margin-left: 60px;
}
</style>
