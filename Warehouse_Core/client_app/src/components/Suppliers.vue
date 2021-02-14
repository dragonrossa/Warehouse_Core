<template>
  <div class="suppliers">
    <Navbar />
    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->

      <p>
        <router-link to="/createsupplier">{{ option1 }}</router-link>
      </p>

      <p>
        <router-link to="/listsupplier">{{ option2 }}</router-link>
      </p>

      <p>
        <router-link to="/updatesupplier">{{ option3 }}</router-link>
      </p>

      <p>
        <router-link to="/deletesupplier">{{ option4 }}</router-link>
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
      title: "Suppliers",
      option1: "Create Supplier",
      option2: "List Supplier",
      option3: "Update Supplier",
      option4: "Delete Supplier",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
