<template>
  <div id="app">
    <Navbar />
    <img alt="Vue logo" id="warehousePicture" src="./assets/warehouse.png" />
    <HelloWorld msg="Welcome to Warehouse" />
    <div id="content">
      <p>{{ option0 }}</p>
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
      <p>
        <router-link to="/back">{{ option11 }}</router-link>
      </p>
    </div>
  </div>
</template>

<script>
import HelloWorld from "./components/StartPage";
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Navbar from "./components/Navbar";

export default {
  name: "App",
  components: {
    HelloWorld,
    Navbar,
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
      option11: "Back - StartPage",
    };
  },
};
</script>

<style scoped src="./assets/style/warehouse_style.css">
</style>

