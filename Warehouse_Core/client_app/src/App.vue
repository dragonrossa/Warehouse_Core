<template>
  <div id="app">
    <Navbar />
    <img
      alt="Vue logo"
      id="warehousePicture"
      src="./assets/warehouse.png"
      v-if="!isHidden"
    />

    <HelloWorld msg="Welcome to Warehouse" />
    <div id="content">
      <p v-if="!isHidden">{{ option0 }}</p>
      <p>
        <router-link to="/admin">
          <span v-on:click="isHidden = !isHidden">
            <span v-if="!isHidden">
              {{ option1 }}
            </span></span
          >
        </router-link>
      </p>
      <p>
        <router-link to="/storage">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option2 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/logs">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option3 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/procurement">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option4 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/search">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option5 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/store">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option6 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/suppliers">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option7 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/task">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option8 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/transfers">
         <span v-on:click="isHidden = !isHidden">
          <span v-if="!isHidden">
            {{ option9 }}
          </span>
            </span>
        </router-link>
      </p>
      <p>
        <router-link to="/users">
         <span v-on:click="isHidden = !isHidden"> <!-- must be false -->
          <span v-if="!isHidden"> <!-- must be false -->
            {{ option10 }}
          </span> 
          </span>
        </router-link>
      </p>
      <p>
        <router-link to="/back">
          <span v-on:click="isHidden = !isHidden">
            {{ option11 }}
          </span>
        </router-link>
      </p>
    </div>
  </div>
</template>

<script>
import HelloWorld from "./components/StartPage";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
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
      isHidden: false,
    };
  },
};
</script>

<style scoped src="./assets/style/warehouse_style.css">
</style>

