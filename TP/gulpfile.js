var path 			= require('path'),
	gulp 			= require('gulp'),
	sass 			= require('gulp-sass'),
	concatFiles 	= require('gulp-concat'),
	cssmin 			= require('gulp-cssmin'),
	rename			= require('gulp-rename'),
	uglify 			= require('gulp-uglify'),
	jslint 			= require('gulp-jslint');

var paths = {
	css: {
		vendor: {
			bootstrap: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\bootstrap\\dist\\css\\boostrap.css'
		},
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css',
		dist: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css\\dist',
	},
	js: {
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\js',
		vendor: {
			jquery: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\jquery\\dist\\jquery.js',
			bootstrap: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\bootstrap\\dist\\js\\bootstrap.js'
		},
		componentes: {
			baseLayout: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\js\\shared\\layout-base.js'
		},
		dist: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\js\\dist'
	},
	img: {
		src: '',
		dest: '',
		vendor: {
			src: ''
		}
	}
};


gulp.task('css', function () {
	return gulp.src([paths.css.vendor.bootstrap, paths.css.src + '\\main.scss'])
		.pipe(sass().on('error', sass.logError))
		.pipe(cssmin({ keepSpecialComments: 0 }))
		.pipe(rename({ suffix: '.min'}))
		.pipe(gulp.dest(paths.css.dist));
});

gulp.task('js.vendor', function(){
	return gulp.src([
		paths.js.vendor.jquery,
		paths.js.vendor.bootstrap
		])
		.pipe(concatFiles('vendors.js'))
		.pipe(gulp.dest(paths.js.dist))
		.pipe(uglify({ compress: true }))
		.pipe(rename({ basename: 'vendors', suffix: '.min' }))
		.pipe(gulp.dest(paths.js.dist));
		
});

gulp.task('js.componentes', function(){
	return gulp.src([
		paths.js.componentes.baseLayout
		])
		.pipe(concatFiles('componentes.js'))
		//.pipe(jslint({this: true}))
		//.pipe(jslint.reporter('default'))
		//.pipe(jslint.reporter('stylish'))
		.pipe(gulp.dest(paths.js.dist))
		.pipe(uglify({ compress: true }))
		.pipe(rename({ basename: 'componentes', suffix: '.min' }))
		.pipe(gulp.dest(paths.js.dist));
});

gulp.task('watch', function(){
	gulp.watch(paths.css.src + '\\*.scss', ['css']);
	gulp.watch([paths.js.src + '\\**\\*.js', '!' + paths.js.dist + '\\*.js'], ['js.vendor', 'js.componentes']);
});

gulp.task('default', ['css', 'js.vendor', 'js.componentes', 'watch']);