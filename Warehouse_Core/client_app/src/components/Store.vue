<template>
  <div class="store">
     <Navbar />
    
    <!-- <div>
    <b-button v-b-toggle.sidebar-footer>Toggle Sidebar</b-button>
    <b-sidebar id="sidebar-footer" aria-label="Sidebar with custom footer" no-header shadow>
      <template #footer="{ hide }">
       <div class="d-flex bg-dark text-light align-items-center px-3 py-2">
        <strong class="mr-auto">Footer</strong>
        <b-button size="sm" @click="hide">Close</b-button>
       </div>
      </template>
      <div class="px-3 py-2">
        <p>
          Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis
          in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.
        </p>
        <b-img src="https://picsum.photos/500/500/?image=54" fluid thumbnail></b-img>
      </div>
    </b-sidebar>
  </div> -->
    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->

      <p>
        <router-link to="/createstore">{{ option1 }}</router-link>
      </p>

      <p>
        <router-link to="/liststores">{{ option2 }}</router-link>
      </p>

      <p>
        <router-link to="/updatestore">{{ option3 }}</router-link>
      </p>

      <p>
        <router-link to="/deletestore">{{ option4 }}</router-link>
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
      title: "Store",
      option1: "Create new store",
      option2: "List all stores",
      option3: "Edit stores",
      option4: "Delete stores",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
