<template>
  <div class="storage">
    <Navbar />
    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->

      <p>
        <router-link to="/createitem">{{ option1 }}</router-link>
      </p>

      <p>
        <router-link to="/listitems">{{ option2 }}</router-link>
      </p>

      <p>
        <router-link to="/updateitem">{{ option3 }}</router-link>
      </p>

      <p>
        <router-link to="/deleteitem">{{ option4 }}</router-link>
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
      title: "Storage",
      option1: "Create item",
      option2: "List items",
      option3: "Update item",
      option4: "Delete item",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
