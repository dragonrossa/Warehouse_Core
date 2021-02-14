<template>
  <div class="transfers">
     <Navbar />
    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->

      <p>
        <router-link to="/createtransfer">{{ option1 }}</router-link>
      </p>

      <p>
        <router-link to="/listtransfers">{{ option2 }}</router-link>
      </p>

      <p>
        <router-link to="/updatetransfer">{{ option3 }}</router-link>
      </p>

      <p>
        <router-link to="/deletetransfer">{{ option4 }}</router-link>
      </p>
    </div>

    <router-view></router-view>
  </div>
</template>

<script>
import Navbar from "./Navbar";

export default {
   components: {
    Navbar,
  },
  data() {
    return {
      title: "Transfers",
      option1: "Create transfer",
      option2: "List transfers",
      option3: "Update transfer",
      option4: "Delete transfer",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
